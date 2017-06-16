/* 
 * Abletech.Arxivar.Server.WebApi.Services
 *
 * No descripton provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthenticationApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// This call provide a new tokenDTO for a given authentication request
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authenticationTokenRequest"></param>
        /// <returns>AuthenticationTokenDTO</returns>
        AuthenticationTokenDTO AuthenticationGetToken (AuthenticationTokenRequestDTO authenticationTokenRequest);

        /// <summary>
        /// This call provide a new tokenDTO for a given authentication request
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authenticationTokenRequest"></param>
        /// <returns>ApiResponse of AuthenticationTokenDTO</returns>
        ApiResponse<AuthenticationTokenDTO> AuthenticationGetTokenWithHttpInfo (AuthenticationTokenRequestDTO authenticationTokenRequest);
        /// <summary>
        /// This call return a new AuthenticationTokenDTO by a refresh token string
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refreshTokenRequest"></param>
        /// <returns>AuthenticationTokenDTO</returns>
        AuthenticationTokenDTO AuthenticationRefresh (RefreshTokenRequestDTO refreshTokenRequest);

        /// <summary>
        /// This call return a new AuthenticationTokenDTO by a refresh token string
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refreshTokenRequest"></param>
        /// <returns>ApiResponse of AuthenticationTokenDTO</returns>
        ApiResponse<AuthenticationTokenDTO> AuthenticationRefreshWithHttpInfo (RefreshTokenRequestDTO refreshTokenRequest);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// This call provide a new tokenDTO for a given authentication request
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authenticationTokenRequest"></param>
        /// <returns>Task of AuthenticationTokenDTO</returns>
        System.Threading.Tasks.Task<AuthenticationTokenDTO> AuthenticationGetTokenAsync (AuthenticationTokenRequestDTO authenticationTokenRequest);

        /// <summary>
        /// This call provide a new tokenDTO for a given authentication request
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authenticationTokenRequest"></param>
        /// <returns>Task of ApiResponse (AuthenticationTokenDTO)</returns>
        System.Threading.Tasks.Task<ApiResponse<AuthenticationTokenDTO>> AuthenticationGetTokenAsyncWithHttpInfo (AuthenticationTokenRequestDTO authenticationTokenRequest);
        /// <summary>
        /// This call return a new AuthenticationTokenDTO by a refresh token string
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refreshTokenRequest"></param>
        /// <returns>Task of AuthenticationTokenDTO</returns>
        System.Threading.Tasks.Task<AuthenticationTokenDTO> AuthenticationRefreshAsync (RefreshTokenRequestDTO refreshTokenRequest);

        /// <summary>
        /// This call return a new AuthenticationTokenDTO by a refresh token string
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refreshTokenRequest"></param>
        /// <returns>Task of ApiResponse (AuthenticationTokenDTO)</returns>
        System.Threading.Tasks.Task<ApiResponse<AuthenticationTokenDTO>> AuthenticationRefreshAsyncWithHttpInfo (RefreshTokenRequestDTO refreshTokenRequest);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AuthenticationApi : IAuthenticationApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthenticationApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AuthenticationApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
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
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
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
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
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
        /// This call provide a new tokenDTO for a given authentication request 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authenticationTokenRequest"></param>
        /// <returns>AuthenticationTokenDTO</returns>
        public AuthenticationTokenDTO AuthenticationGetToken (AuthenticationTokenRequestDTO authenticationTokenRequest)
        {
             ApiResponse<AuthenticationTokenDTO> localVarResponse = AuthenticationGetTokenWithHttpInfo(authenticationTokenRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// This call provide a new tokenDTO for a given authentication request 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authenticationTokenRequest"></param>
        /// <returns>ApiResponse of AuthenticationTokenDTO</returns>
        public ApiResponse< AuthenticationTokenDTO > AuthenticationGetTokenWithHttpInfo (AuthenticationTokenRequestDTO authenticationTokenRequest)
        {
            // verify the required parameter 'authenticationTokenRequest' is set
            if (authenticationTokenRequest == null)
                throw new ApiException(400, "Missing required parameter 'authenticationTokenRequest' when calling AuthenticationApi->AuthenticationGetToken");

            var localVarPath = "/api/Authentication";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (authenticationTokenRequest != null && authenticationTokenRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(authenticationTokenRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = authenticationTokenRequest; // byte array
            }

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AuthenticationGetToken", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AuthenticationTokenDTO>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AuthenticationTokenDTO) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthenticationTokenDTO)));
            
        }

        /// <summary>
        /// This call provide a new tokenDTO for a given authentication request 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authenticationTokenRequest"></param>
        /// <returns>Task of AuthenticationTokenDTO</returns>
        public async System.Threading.Tasks.Task<AuthenticationTokenDTO> AuthenticationGetTokenAsync (AuthenticationTokenRequestDTO authenticationTokenRequest)
        {
             ApiResponse<AuthenticationTokenDTO> localVarResponse = await AuthenticationGetTokenAsyncWithHttpInfo(authenticationTokenRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// This call provide a new tokenDTO for a given authentication request 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authenticationTokenRequest"></param>
        /// <returns>Task of ApiResponse (AuthenticationTokenDTO)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AuthenticationTokenDTO>> AuthenticationGetTokenAsyncWithHttpInfo (AuthenticationTokenRequestDTO authenticationTokenRequest)
        {
            // verify the required parameter 'authenticationTokenRequest' is set
            if (authenticationTokenRequest == null)
                throw new ApiException(400, "Missing required parameter 'authenticationTokenRequest' when calling AuthenticationApi->AuthenticationGetToken");

            var localVarPath = "/api/Authentication";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (authenticationTokenRequest != null && authenticationTokenRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(authenticationTokenRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = authenticationTokenRequest; // byte array
            }

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AuthenticationGetToken", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AuthenticationTokenDTO>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AuthenticationTokenDTO) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthenticationTokenDTO)));
            
        }

        /// <summary>
        /// This call return a new AuthenticationTokenDTO by a refresh token string 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refreshTokenRequest"></param>
        /// <returns>AuthenticationTokenDTO</returns>
        public AuthenticationTokenDTO AuthenticationRefresh (RefreshTokenRequestDTO refreshTokenRequest)
        {
             ApiResponse<AuthenticationTokenDTO> localVarResponse = AuthenticationRefreshWithHttpInfo(refreshTokenRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// This call return a new AuthenticationTokenDTO by a refresh token string 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refreshTokenRequest"></param>
        /// <returns>ApiResponse of AuthenticationTokenDTO</returns>
        public ApiResponse< AuthenticationTokenDTO > AuthenticationRefreshWithHttpInfo (RefreshTokenRequestDTO refreshTokenRequest)
        {
            // verify the required parameter 'refreshTokenRequest' is set
            if (refreshTokenRequest == null)
                throw new ApiException(400, "Missing required parameter 'refreshTokenRequest' when calling AuthenticationApi->AuthenticationRefresh");

            var localVarPath = "/api/Authentication/refreshtoken";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (refreshTokenRequest != null && refreshTokenRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(refreshTokenRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = refreshTokenRequest; // byte array
            }

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AuthenticationRefresh", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AuthenticationTokenDTO>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AuthenticationTokenDTO) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthenticationTokenDTO)));
            
        }

        /// <summary>
        /// This call return a new AuthenticationTokenDTO by a refresh token string 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refreshTokenRequest"></param>
        /// <returns>Task of AuthenticationTokenDTO</returns>
        public async System.Threading.Tasks.Task<AuthenticationTokenDTO> AuthenticationRefreshAsync (RefreshTokenRequestDTO refreshTokenRequest)
        {
             ApiResponse<AuthenticationTokenDTO> localVarResponse = await AuthenticationRefreshAsyncWithHttpInfo(refreshTokenRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// This call return a new AuthenticationTokenDTO by a refresh token string 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refreshTokenRequest"></param>
        /// <returns>Task of ApiResponse (AuthenticationTokenDTO)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AuthenticationTokenDTO>> AuthenticationRefreshAsyncWithHttpInfo (RefreshTokenRequestDTO refreshTokenRequest)
        {
            // verify the required parameter 'refreshTokenRequest' is set
            if (refreshTokenRequest == null)
                throw new ApiException(400, "Missing required parameter 'refreshTokenRequest' when calling AuthenticationApi->AuthenticationRefresh");

            var localVarPath = "/api/Authentication/refreshtoken";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (refreshTokenRequest != null && refreshTokenRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(refreshTokenRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = refreshTokenRequest; // byte array
            }

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AuthenticationRefresh", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AuthenticationTokenDTO>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AuthenticationTokenDTO) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthenticationTokenDTO)));
            
        }

    }
}
