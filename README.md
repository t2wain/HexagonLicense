## Intergraph Smart License (ISL) Web Service

Intergraph provides license usage information of its software from an OData web service. As a minimum, current usage level info, historic usage level info, and license quantities info are available from the web service. To use the the web service, Intergraph will provide you with the following information.

- Client ID
- Client Secret
- Company Code

It is important to keep these information a secret to prevent unauthorize access to the data by others outside of your organization.

The web service public endpoints are:

- API Server: `https://ppm-licensingportalapi-prod.hexagonsmartlicensing.com`
- Identity Server: `https://identityserver.hexagonppm.com`

## Get an Access Token from Identity Server

The first step is to request an access token from the Identity server. The access token is a long-live credential with an expiration date. You should store this access token so you can reuse it later. When the token expired, you will need to request another access token. Multiple active tokens is allowed. The access token is needed to access the API server. The access token must be included in every HTTP web request header as a Bearer token.

## Generate an OData Proxy Client

OData is a standard HTTP protocol similar to the REST web service architecture. The metadata for the web service can be found from this standard URL:

- Metadata info: <a href="https://ppm-licensingportalapi-prod.hexagonsmartlicensing.com/$metadata" target="_blank">https://ppm-licensingportalapi-prod.hexagonsmartlicensing.com/$metadata</a>

There are many tools available to parse the OData metadata and generate the necessary client codes for use in your application. The codes include the OData proxy client and all the classes for use in serializing/deserializing the web request/response JSON data.

## Get Data from the API Server

All call to the web service are HTTP calls to specific URLs. You can assemble these URLs manually and use a web client ( like Postman ) to call the API server. The URL format is well-defined as specified in the OData standards. The web response data is in JSON format. When using the generated OData proxy client, the client will assemble the URL for you and serialize/deserialize all the data to/from JSON data format.

 Typically, you will want to save these data to a database for analysis. Examples of data analysis could be like these:

- <a href="https://t2wain.github.io/tan-chartjs/" target="_blank">Stack bar chart</a> showing hourly peak license usage level (available, in-use, expired)
- <a href="https://t2wain.github.io/tan-datatable/" target="_blank">Data table</a> showing detail license usage by users

## Benefits of Analyzing Usage Data

Intergraph has a very diverse licensing options:

- Purchase perpetual licenses
- Lease licenses for certain period of time
- Licenses can be 12-hour or 24-hour types
- Licenses are associated with KeyStore which can be reserved for certain groups of users
- Multiple different software will require different licenses
- A software can have multiple modules and each module might require different licenses

Analyzing the license usage information will allow each software administrator to perform the following for his software:

- Lease licenses based on past level of usage that typically corresponds to cyclical work loads
- Monitor license usage in real-time (which software, who is using it, from which computer, and for how long)
- Manage budget for licenses

Note, Intergraph does provide a portal web application to view these usage information. However, organization typically will restrict access only to a few users because of other admin functionalities in the portal. Also, the analytical functionalities in the portal may not be adequate for the specific needs of the organization.

