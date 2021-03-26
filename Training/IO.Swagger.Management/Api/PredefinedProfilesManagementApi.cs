/* 
 * WebAPI - Area Management
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: management
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Management.Client;
using IO.Swagger.Management.Model;

namespace IO.Swagger.Management.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPredefinedProfilesManagementApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// This call returns all the predefined profiles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Management.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;PredefinedProfileDTO&gt;</returns>
        List<PredefinedProfileDTO> PredefinedProfilesManagementGet ();

        /// <summary>
        /// This call returns all the predefined profiles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Management.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;PredefinedProfileDTO&gt;</returns>
        ApiResponse<List<PredefinedProfileDTO>> PredefinedProfilesManagementGetWithHttpInfo ();
        /// <summary>
        /// This call returns a predefined profile by its id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Management.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predefinedProfileId">Predefined profile identifier</param>
        /// <returns>PredefinedProfileDTO</returns>
        PredefinedProfileDTO PredefinedProfilesManagementGetById (int? predefinedProfileId);

        /// <summary>
        /// This call returns a predefined profile by its id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Management.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predefinedProfileId">Predefined profile identifier</param>
        /// <returns>ApiResponse of PredefinedProfileDTO</returns>
        ApiResponse<PredefinedProfileDTO> PredefinedProfilesManagementGetByIdWithHttpInfo (int? predefinedProfileId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// This call returns all the predefined profiles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Management.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;PredefinedProfileDTO&gt;</returns>
        System.Threading.Tasks.Task<List<PredefinedProfileDTO>> PredefinedProfilesManagementGetAsync ();

        /// <summary>
        /// This call returns all the predefined profiles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Management.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;PredefinedProfileDTO&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<PredefinedProfileDTO>>> PredefinedProfilesManagementGetAsyncWithHttpInfo ();
        /// <summary>
        /// This call returns a predefined profile by its id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Management.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predefinedProfileId">Predefined profile identifier</param>
        /// <returns>Task of PredefinedProfileDTO</returns>
        System.Threading.Tasks.Task<PredefinedProfileDTO> PredefinedProfilesManagementGetByIdAsync (int? predefinedProfileId);

        /// <summary>
        /// This call returns a predefined profile by its id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Management.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predefinedProfileId">Predefined profile identifier</param>
        /// <returns>Task of ApiResponse (PredefinedProfileDTO)</returns>
        System.Threading.Tasks.Task<ApiResponse<PredefinedProfileDTO>> PredefinedProfilesManagementGetByIdAsyncWithHttpInfo (int? predefinedProfileId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PredefinedProfilesManagementApi : IPredefinedProfilesManagementApi
    {
        private IO.Swagger.Management.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PredefinedProfilesManagementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PredefinedProfilesManagementApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Management.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Management.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PredefinedProfilesManagementApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PredefinedProfilesManagementApi(IO.Swagger.Management.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = IO.Swagger.Management.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Management.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IO.Swagger.Management.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Management.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// This call returns all the predefined profiles 
        /// </summary>
        /// <exception cref="IO.Swagger.Management.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;PredefinedProfileDTO&gt;</returns>
        public List<PredefinedProfileDTO> PredefinedProfilesManagementGet ()
        {
             ApiResponse<List<PredefinedProfileDTO>> localVarResponse = PredefinedProfilesManagementGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// This call returns all the predefined profiles 
        /// </summary>
        /// <exception cref="IO.Swagger.Management.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;PredefinedProfileDTO&gt;</returns>
        public ApiResponse< List<PredefinedProfileDTO> > PredefinedProfilesManagementGetWithHttpInfo ()
        {

            var localVarPath = "/api/management/PredefinedProfiles";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PredefinedProfilesManagementGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<PredefinedProfileDTO>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<PredefinedProfileDTO>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<PredefinedProfileDTO>)));
        }

        /// <summary>
        /// This call returns all the predefined profiles 
        /// </summary>
        /// <exception cref="IO.Swagger.Management.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;PredefinedProfileDTO&gt;</returns>
        public async System.Threading.Tasks.Task<List<PredefinedProfileDTO>> PredefinedProfilesManagementGetAsync ()
        {
             ApiResponse<List<PredefinedProfileDTO>> localVarResponse = await PredefinedProfilesManagementGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// This call returns all the predefined profiles 
        /// </summary>
        /// <exception cref="IO.Swagger.Management.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;PredefinedProfileDTO&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<PredefinedProfileDTO>>> PredefinedProfilesManagementGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/management/PredefinedProfiles";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PredefinedProfilesManagementGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<PredefinedProfileDTO>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<PredefinedProfileDTO>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<PredefinedProfileDTO>)));
        }

        /// <summary>
        /// This call returns a predefined profile by its id 
        /// </summary>
        /// <exception cref="IO.Swagger.Management.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predefinedProfileId">Predefined profile identifier</param>
        /// <returns>PredefinedProfileDTO</returns>
        public PredefinedProfileDTO PredefinedProfilesManagementGetById (int? predefinedProfileId)
        {
             ApiResponse<PredefinedProfileDTO> localVarResponse = PredefinedProfilesManagementGetByIdWithHttpInfo(predefinedProfileId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// This call returns a predefined profile by its id 
        /// </summary>
        /// <exception cref="IO.Swagger.Management.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predefinedProfileId">Predefined profile identifier</param>
        /// <returns>ApiResponse of PredefinedProfileDTO</returns>
        public ApiResponse< PredefinedProfileDTO > PredefinedProfilesManagementGetByIdWithHttpInfo (int? predefinedProfileId)
        {
            // verify the required parameter 'predefinedProfileId' is set
            if (predefinedProfileId == null)
                throw new ApiException(400, "Missing required parameter 'predefinedProfileId' when calling PredefinedProfilesManagementApi->PredefinedProfilesManagementGetById");

            var localVarPath = "/api/management/PredefinedProfiles/{predefinedProfileId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (predefinedProfileId != null) localVarPathParams.Add("predefinedProfileId", this.Configuration.ApiClient.ParameterToString(predefinedProfileId)); // path parameter

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PredefinedProfilesManagementGetById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PredefinedProfileDTO>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PredefinedProfileDTO) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PredefinedProfileDTO)));
        }

        /// <summary>
        /// This call returns a predefined profile by its id 
        /// </summary>
        /// <exception cref="IO.Swagger.Management.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predefinedProfileId">Predefined profile identifier</param>
        /// <returns>Task of PredefinedProfileDTO</returns>
        public async System.Threading.Tasks.Task<PredefinedProfileDTO> PredefinedProfilesManagementGetByIdAsync (int? predefinedProfileId)
        {
             ApiResponse<PredefinedProfileDTO> localVarResponse = await PredefinedProfilesManagementGetByIdAsyncWithHttpInfo(predefinedProfileId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// This call returns a predefined profile by its id 
        /// </summary>
        /// <exception cref="IO.Swagger.Management.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="predefinedProfileId">Predefined profile identifier</param>
        /// <returns>Task of ApiResponse (PredefinedProfileDTO)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PredefinedProfileDTO>> PredefinedProfilesManagementGetByIdAsyncWithHttpInfo (int? predefinedProfileId)
        {
            // verify the required parameter 'predefinedProfileId' is set
            if (predefinedProfileId == null)
                throw new ApiException(400, "Missing required parameter 'predefinedProfileId' when calling PredefinedProfilesManagementApi->PredefinedProfilesManagementGetById");

            var localVarPath = "/api/management/PredefinedProfiles/{predefinedProfileId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (predefinedProfileId != null) localVarPathParams.Add("predefinedProfileId", this.Configuration.ApiClient.ParameterToString(predefinedProfileId)); // path parameter

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PredefinedProfilesManagementGetById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PredefinedProfileDTO>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PredefinedProfileDTO) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PredefinedProfileDTO)));
        }

    }
}
