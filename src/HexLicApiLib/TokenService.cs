using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HexLicApiLib
{
    /// <summary>
    /// Manage the access token value needed to
    /// call the license web service API.
    /// </summary>
    public class TokenService
    {
        public class Token
        {
            public string access_token { get; set; }
            public int expires_in { get; set; }
            public string token_type { get; set; }
            public DateTime? date_expired { get; set; }
            [JsonIgnore]
            public bool IsExpired => !date_expired.HasValue
                && DateTime.Now.AddDays(7) > date_expired.Value;
        }

        private readonly ApiConfig _cfg;

        public TokenService(ApiConfig cfg)
        {
            this._cfg = cfg;
            this.GetToken(); // caching a valid token  
        }

        protected ApiConfig Config => _cfg;

        private object _tokenlock = new object();
        private Token _token = null;

        /// <summary>
        /// Get saved token and if expired then
        /// request a new token.
        /// </summary>
        public Token GetToken()
        {
            // lock is required to access the cache token since
            // a this method might require read/write
            // value from/to a file.
            lock (_tokenlock)
            {
                if (_token == null)
                {
                    // get saved token from data file 
                    _token = ParseToken(ReadToken(Config.TokenFileName));
                    if (_token.IsExpired)
                    {
                        // request new token from API
                        _token = RefreshToken().Result;
                    }
                }
                return _token;
            }
        }

        #region Token file

        /// <summary>
        /// Deserialize JSON value to token
        /// </summary>
        protected Token ParseToken(string jsonToken)
        {
            var t = new Token();
            try
            {
                if (!string.IsNullOrEmpty(jsonToken))
                {
                    t = JsonSerializer.Deserialize<Token>(jsonToken);
                    // data from api does not have the property
                    // data from saved file has this property
                    if (!t.date_expired.HasValue) 
                        t.date_expired = DateTime.Now.AddSeconds(t.expires_in);
                }
            }
            catch { }
            return t;
        }

        /// <summary>
        /// Save JSON serialized token value to file
        /// </summary>
        public void SaveToken(string fileName, string json)
        {
            // exclusive lock on file before writing
            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
            using (var sw = new StreamWriter(fs))
            {
                fs.SetLength(0);
                sw.WriteLine(json);
            }
        }

        /// <summary>
        /// Read JSON serialized token value from file
        /// </summary>
        public string ReadToken(string fileName)
        {
            var data = "";
            var fi = new FileInfo(fileName);
            if (!fi.Exists)
                return data;

            // allow concurrent reading of file
            using (var fs = new FileStream(fi.FullName, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (var rd = new StreamReader(fs))
            {
                data = rd.ReadToEnd();
            }
            return data;
        }

        #endregion

        #region API

        /// <summary>
        /// Request a new access token from web service API
        /// then save it to a file for later use.
        /// </summary>
        public Task<Token> RefreshToken()
        {
            return this.GetTokenJsonFromApi().ContinueWith(t =>
            {
                var data = t.Result;
                var token = ParseToken(data);
                var json = JsonSerializer.Serialize(token);
                SaveToken(Config.TokenFileName, json);
                return token;
            });
        }

        /// <summary>
        /// Call the web service API to request a new access token.
        /// </summary>
        public Task<string> GetTokenJsonFromApi()
        {
            using (var wc = new WebClient())
            {
                var connectTokenUri = new Uri(new Uri(Config.IdentityServerUrl), "/connect/token").AbsoluteUri;
                wc.Headers.Set("Content-Type", "application/x-www-form-urlencoded");
                var reqparams = new NameValueCollection() { 
                    { "grant_type", "client_credentials" },
                    { "scope", Config.ApiScope },
                    { "client_id", Config.ClientId },
                    { "client_secret", Config.ClientSecret }
                };
                return wc
                    .UploadValuesTaskAsync(connectTokenUri, "POST", reqparams)
                    .ContinueWith(t =>
                    {
                        var responsebytes = t.Result;
                        var responsebody = new UTF8Encoding().GetString(responsebytes);
                        return responsebody;

                    });
            }
        }

        #endregion
    }
}
