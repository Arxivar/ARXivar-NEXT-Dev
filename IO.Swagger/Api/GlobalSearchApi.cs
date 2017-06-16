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
    public interface IGlobalSearchApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// This call return the result of a serch in ARXivar full index
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchFilter"></param>
        /// <returns>List&lt;RowSearchResult&gt;</returns>
        List<RowSearchResult> GlobalSearchGetFullIndexSearch (string searchFilter);

        /// <summary>
        /// This call return the result of a serch in ARXivar full index
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchFilter"></param>
        /// <returns>ApiResponse of List&lt;RowSearchResult&gt;</returns>
        ApiResponse<List<RowSearchResult>> GlobalSearchGetFullIndexSearchWithHttpInfo (string searchFilter);
        /// <summary>
        /// This call return all elements match the given filter
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchFilter"></param>
        /// <returns>List&lt;GenericItemDTO&gt;</returns>
        List<GenericItemDTO> GlobalSearchGlobalSearch (string searchFilter);

        /// <summary>
        /// This call return all elements match the given filter
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchFilter"></param>
        /// <returns>ApiResponse of List&lt;GenericItemDTO&gt;</returns>
        ApiResponse<List<GenericItemDTO>> GlobalSearchGlobalSearchWithHttpInfo (string searchFilter);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// This call return the result of a serch in ARXivar full index
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchFilter"></param>
        /// <returns>Task of List&lt;RowSearchResult&gt;</returns>
        System.Threading.Tasks.Task<List<RowSearchResult>> GlobalSearchGetFullIndexSearchAsync (string searchFilter);

        /// <summary>
        /// This call return the result of a serch in ARXivar full index
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchFilter"></param>
        /// <returns>Task of ApiResponse (List&lt;RowSearchResult&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<RowSearchResult>>> GlobalSearchGetFullIndexSearchAsyncWithHttpInfo (string searchFilter);
        /// <summary>
        /// This call return all elements match the given filter
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchFilter"></param>
        /// <returns>Task of List&lt;GenericItemDTO&gt;</returns>
        System.Threading.Tasks.Task<List<GenericItemDTO>> GlobalSearchGlobalSearchAsync (string searchFilter);

        /// <summary>
        /// This call return all elements match the given filter
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchFilter"></param>
        /// <returns>Task of ApiResponse (List&lt;GenericItemDTO&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<GenericItemDTO>>> GlobalSearchGlobalSearchAsyncWithHttpInfo (string searchFilter);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class GlobalSearchApi : IGlobalSearchApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalSearchApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GlobalSearchApi(String basePath)
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
        /// Initializes a new instance of the <see cref="GlobalSearchApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GlobalSearchApi(Configuration configuration = null)
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
        /// This call return the result of a serch in ARXivar full index 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchFilter"></param>
        /// <returns>List&lt;RowSearchResult&gt;</returns>
        public List<RowSearchResult> GlobalSearchGetFullIndexSearch (string searchFilter)
        {
             ApiResponse<List<RowSearchResult>> localVarResponse = GlobalSearchGetFullIndexSearchWithHttpInfo(searchFilter);
             return localVarResponse.Data;
        }

        /// <summary>
        /// This call return the result of a serch in ARXivar full index 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchFilter"></param>
        /// <returns>ApiResponse of List&lt;RowSearchResult&gt;</returns>
        public ApiResponse< List<RowSearchResult> > GlobalSearchGetFullIndexSearchWithHttpInfo (string searchFilter)
        {
            // verify the required parameter 'searchFilter' is set
            if (searchFilter == null)
                throw new ApiException(400, "Missing required parameter 'searchFilter' when calling GlobalSearchApi->GlobalSearchGetFullIndexSearch");

            var localVarPath = "/api/GlobalSearches/search/{searchFilter}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
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
            if (searchFilter != null) localVarPathParams.Add("searchFilter", Configuration.ApiClient.ParameterToString(searchFilter)); // path parameter

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GlobalSearchGetFullIndexSearch", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<RowSearchResult>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<RowSearchResult>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<RowSearchResult>)));
            
        }

        /// <summary>
        /// This call return the result of a serch in ARXivar full index 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchFilter"></param>
        /// <returns>Task of List&lt;RowSearchResult&gt;</returns>
        public async System.Threading.Tasks.Task<List<RowSearchResult>> GlobalSearchGetFullIndexSearchAsync (string searchFilter)
        {
             ApiResponse<List<RowSearchResult>> localVarResponse = await GlobalSearchGetFullIndexSearchAsyncWithHttpInfo(searchFilter);
             return localVarResponse.Data;

        }

        /// <summary>
        /// This call return the result of a serch in ARXivar full index 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchFilter"></param>
        /// <returns>Task of ApiResponse (List&lt;RowSearchResult&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<RowSearchResult>>> GlobalSearchGetFullIndexSearchAsyncWithHttpInfo (string searchFilter)
        {
            // verify the required parameter 'searchFilter' is set
            if (searchFilter == null)
                throw new ApiException(400, "Missing required parameter 'searchFilter' when calling GlobalSearchApi->GlobalSearchGetFullIndexSearch");

            var localVarPath = "/api/GlobalSearches/search/{searchFilter}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
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
            if (searchFilter != null) localVarPathParams.Add("searchFilter", Configuration.ApiClient.ParameterToString(searchFilter)); // path parameter

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GlobalSearchGetFullIndexSearch", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<RowSearchResult>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<RowSearchResult>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<RowSearchResult>)));
            
        }

        /// <summary>
        /// This call return all elements match the given filter 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchFilter"></param>
        /// <returns>List&lt;GenericItemDTO&gt;</returns>
        public List<GenericItemDTO> GlobalSearchGlobalSearch (string searchFilter)
        {
             ApiResponse<List<GenericItemDTO>> localVarResponse = GlobalSearchGlobalSearchWithHttpInfo(searchFilter);
             return localVarResponse.Data;
        }

        /// <summary>
        /// This call return all elements match the given filter 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchFilter"></param>
        /// <returns>ApiResponse of List&lt;GenericItemDTO&gt;</returns>
        public ApiResponse< List<GenericItemDTO> > GlobalSearchGlobalSearchWithHttpInfo (string searchFilter)
        {
            // verify the required parameter 'searchFilter' is set
            if (searchFilter == null)
                throw new ApiException(400, "Missing required parameter 'searchFilter' when calling GlobalSearchApi->GlobalSearchGlobalSearch");

            var localVarPath = "/api/GlobalSearches/{searchFilter}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
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
            if (searchFilter != null) localVarPathParams.Add("searchFilter", Configuration.ApiClient.ParameterToString(searchFilter)); // path parameter

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GlobalSearchGlobalSearch", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<GenericItemDTO>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<GenericItemDTO>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<GenericItemDTO>)));
            
        }

        /// <summary>
        /// This call return all elements match the given filter 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchFilter"></param>
        /// <returns>Task of List&lt;GenericItemDTO&gt;</returns>
        public async System.Threading.Tasks.Task<List<GenericItemDTO>> GlobalSearchGlobalSearchAsync (string searchFilter)
        {
             ApiResponse<List<GenericItemDTO>> localVarResponse = await GlobalSearchGlobalSearchAsyncWithHttpInfo(searchFilter);
             return localVarResponse.Data;

        }

        /// <summary>
        /// This call return all elements match the given filter 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchFilter"></param>
        /// <returns>Task of ApiResponse (List&lt;GenericItemDTO&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<GenericItemDTO>>> GlobalSearchGlobalSearchAsyncWithHttpInfo (string searchFilter)
        {
            // verify the required parameter 'searchFilter' is set
            if (searchFilter == null)
                throw new ApiException(400, "Missing required parameter 'searchFilter' when calling GlobalSearchApi->GlobalSearchGlobalSearch");

            var localVarPath = "/api/GlobalSearches/{searchFilter}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
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
            if (searchFilter != null) localVarPathParams.Add("searchFilter", Configuration.ApiClient.ParameterToString(searchFilter)); // path parameter

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GlobalSearchGlobalSearch", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<GenericItemDTO>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<GenericItemDTO>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<GenericItemDTO>)));
            
        }

    }
}
