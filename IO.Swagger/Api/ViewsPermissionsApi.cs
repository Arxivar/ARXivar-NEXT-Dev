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
    public interface IViewsPermissionsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// This call returns all permissions for a view
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Id of the view</param>
        /// <returns>PermissionsDTO</returns>
        PermissionsDTO ViewsPermissionsGetPermissionByView (string viewId);

        /// <summary>
        /// This call returns all permissions for a view
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Id of the view</param>
        /// <returns>ApiResponse of PermissionsDTO</returns>
        ApiResponse<PermissionsDTO> ViewsPermissionsGetPermissionByViewWithHttpInfo (string viewId);
        /// <summary>
        /// This call save permissions for a view
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Id of the view</param>
        /// <param name="permissions">Permission to set</param>
        /// <returns></returns>
        void ViewsPermissionsWritePermissionByView (string viewId, PermissionsDTO permissions);

        /// <summary>
        /// This call save permissions for a view
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Id of the view</param>
        /// <param name="permissions">Permission to set</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ViewsPermissionsWritePermissionByViewWithHttpInfo (string viewId, PermissionsDTO permissions);
        /// <summary>
        /// This call save permissions for a view
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Id of the view</param>
        /// <param name="permissions">Permission to set</param>
        /// <returns></returns>
        void ViewsPermissionsWritePermissionByView_0 (string viewId, PermissionsDTO permissions);

        /// <summary>
        /// This call save permissions for a view
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Id of the view</param>
        /// <param name="permissions">Permission to set</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ViewsPermissionsWritePermissionByView_0WithHttpInfo (string viewId, PermissionsDTO permissions);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// This call returns all permissions for a view
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Id of the view</param>
        /// <returns>Task of PermissionsDTO</returns>
        System.Threading.Tasks.Task<PermissionsDTO> ViewsPermissionsGetPermissionByViewAsync (string viewId);

        /// <summary>
        /// This call returns all permissions for a view
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Id of the view</param>
        /// <returns>Task of ApiResponse (PermissionsDTO)</returns>
        System.Threading.Tasks.Task<ApiResponse<PermissionsDTO>> ViewsPermissionsGetPermissionByViewAsyncWithHttpInfo (string viewId);
        /// <summary>
        /// This call save permissions for a view
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Id of the view</param>
        /// <param name="permissions">Permission to set</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ViewsPermissionsWritePermissionByViewAsync (string viewId, PermissionsDTO permissions);

        /// <summary>
        /// This call save permissions for a view
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Id of the view</param>
        /// <param name="permissions">Permission to set</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ViewsPermissionsWritePermissionByViewAsyncWithHttpInfo (string viewId, PermissionsDTO permissions);
        /// <summary>
        /// This call save permissions for a view
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Id of the view</param>
        /// <param name="permissions">Permission to set</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ViewsPermissionsWritePermissionByView_0Async (string viewId, PermissionsDTO permissions);

        /// <summary>
        /// This call save permissions for a view
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Id of the view</param>
        /// <param name="permissions">Permission to set</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ViewsPermissionsWritePermissionByView_0AsyncWithHttpInfo (string viewId, PermissionsDTO permissions);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ViewsPermissionsApi : IViewsPermissionsApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewsPermissionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ViewsPermissionsApi(String basePath)
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
        /// Initializes a new instance of the <see cref="ViewsPermissionsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ViewsPermissionsApi(Configuration configuration = null)
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
        /// This call returns all permissions for a view 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Id of the view</param>
        /// <returns>PermissionsDTO</returns>
        public PermissionsDTO ViewsPermissionsGetPermissionByView (string viewId)
        {
             ApiResponse<PermissionsDTO> localVarResponse = ViewsPermissionsGetPermissionByViewWithHttpInfo(viewId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// This call returns all permissions for a view 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Id of the view</param>
        /// <returns>ApiResponse of PermissionsDTO</returns>
        public ApiResponse< PermissionsDTO > ViewsPermissionsGetPermissionByViewWithHttpInfo (string viewId)
        {
            // verify the required parameter 'viewId' is set
            if (viewId == null)
                throw new ApiException(400, "Missing required parameter 'viewId' when calling ViewsPermissionsApi->ViewsPermissionsGetPermissionByView");

            var localVarPath = "/api/ViewsPermissions/{viewId}";
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
            if (viewId != null) localVarPathParams.Add("viewId", Configuration.ApiClient.ParameterToString(viewId)); // path parameter

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
                Exception exception = ExceptionFactory("ViewsPermissionsGetPermissionByView", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PermissionsDTO>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PermissionsDTO) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PermissionsDTO)));
            
        }

        /// <summary>
        /// This call returns all permissions for a view 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Id of the view</param>
        /// <returns>Task of PermissionsDTO</returns>
        public async System.Threading.Tasks.Task<PermissionsDTO> ViewsPermissionsGetPermissionByViewAsync (string viewId)
        {
             ApiResponse<PermissionsDTO> localVarResponse = await ViewsPermissionsGetPermissionByViewAsyncWithHttpInfo(viewId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// This call returns all permissions for a view 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Id of the view</param>
        /// <returns>Task of ApiResponse (PermissionsDTO)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PermissionsDTO>> ViewsPermissionsGetPermissionByViewAsyncWithHttpInfo (string viewId)
        {
            // verify the required parameter 'viewId' is set
            if (viewId == null)
                throw new ApiException(400, "Missing required parameter 'viewId' when calling ViewsPermissionsApi->ViewsPermissionsGetPermissionByView");

            var localVarPath = "/api/ViewsPermissions/{viewId}";
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
            if (viewId != null) localVarPathParams.Add("viewId", Configuration.ApiClient.ParameterToString(viewId)); // path parameter

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
                Exception exception = ExceptionFactory("ViewsPermissionsGetPermissionByView", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PermissionsDTO>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PermissionsDTO) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PermissionsDTO)));
            
        }

        /// <summary>
        /// This call save permissions for a view 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Id of the view</param>
        /// <param name="permissions">Permission to set</param>
        /// <returns></returns>
        public void ViewsPermissionsWritePermissionByView (string viewId, PermissionsDTO permissions)
        {
             ViewsPermissionsWritePermissionByViewWithHttpInfo(viewId, permissions);
        }

        /// <summary>
        /// This call save permissions for a view 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Id of the view</param>
        /// <param name="permissions">Permission to set</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ViewsPermissionsWritePermissionByViewWithHttpInfo (string viewId, PermissionsDTO permissions)
        {
            // verify the required parameter 'viewId' is set
            if (viewId == null)
                throw new ApiException(400, "Missing required parameter 'viewId' when calling ViewsPermissionsApi->ViewsPermissionsWritePermissionByView");
            // verify the required parameter 'permissions' is set
            if (permissions == null)
                throw new ApiException(400, "Missing required parameter 'permissions' when calling ViewsPermissionsApi->ViewsPermissionsWritePermissionByView");

            var localVarPath = "/api/ViewsPermissions/{viewId}";
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
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (viewId != null) localVarPathParams.Add("viewId", Configuration.ApiClient.ParameterToString(viewId)); // path parameter
            if (permissions != null && permissions.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(permissions); // http body (model) parameter
            }
            else
            {
                localVarPostBody = permissions; // byte array
            }

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ViewsPermissionsWritePermissionByView", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// This call save permissions for a view 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Id of the view</param>
        /// <param name="permissions">Permission to set</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ViewsPermissionsWritePermissionByViewAsync (string viewId, PermissionsDTO permissions)
        {
             await ViewsPermissionsWritePermissionByViewAsyncWithHttpInfo(viewId, permissions);

        }

        /// <summary>
        /// This call save permissions for a view 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Id of the view</param>
        /// <param name="permissions">Permission to set</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ViewsPermissionsWritePermissionByViewAsyncWithHttpInfo (string viewId, PermissionsDTO permissions)
        {
            // verify the required parameter 'viewId' is set
            if (viewId == null)
                throw new ApiException(400, "Missing required parameter 'viewId' when calling ViewsPermissionsApi->ViewsPermissionsWritePermissionByView");
            // verify the required parameter 'permissions' is set
            if (permissions == null)
                throw new ApiException(400, "Missing required parameter 'permissions' when calling ViewsPermissionsApi->ViewsPermissionsWritePermissionByView");

            var localVarPath = "/api/ViewsPermissions/{viewId}";
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
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (viewId != null) localVarPathParams.Add("viewId", Configuration.ApiClient.ParameterToString(viewId)); // path parameter
            if (permissions != null && permissions.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(permissions); // http body (model) parameter
            }
            else
            {
                localVarPostBody = permissions; // byte array
            }

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ViewsPermissionsWritePermissionByView", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// This call save permissions for a view 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Id of the view</param>
        /// <param name="permissions">Permission to set</param>
        /// <returns></returns>
        public void ViewsPermissionsWritePermissionByView_0 (string viewId, PermissionsDTO permissions)
        {
             ViewsPermissionsWritePermissionByView_0WithHttpInfo(viewId, permissions);
        }

        /// <summary>
        /// This call save permissions for a view 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Id of the view</param>
        /// <param name="permissions">Permission to set</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ViewsPermissionsWritePermissionByView_0WithHttpInfo (string viewId, PermissionsDTO permissions)
        {
            // verify the required parameter 'viewId' is set
            if (viewId == null)
                throw new ApiException(400, "Missing required parameter 'viewId' when calling ViewsPermissionsApi->ViewsPermissionsWritePermissionByView_0");
            // verify the required parameter 'permissions' is set
            if (permissions == null)
                throw new ApiException(400, "Missing required parameter 'permissions' when calling ViewsPermissionsApi->ViewsPermissionsWritePermissionByView_0");

            var localVarPath = "/api/ViewsPermissions/{viewId}";
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
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (viewId != null) localVarPathParams.Add("viewId", Configuration.ApiClient.ParameterToString(viewId)); // path parameter
            if (permissions != null && permissions.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(permissions); // http body (model) parameter
            }
            else
            {
                localVarPostBody = permissions; // byte array
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
                Exception exception = ExceptionFactory("ViewsPermissionsWritePermissionByView_0", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// This call save permissions for a view 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Id of the view</param>
        /// <param name="permissions">Permission to set</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ViewsPermissionsWritePermissionByView_0Async (string viewId, PermissionsDTO permissions)
        {
             await ViewsPermissionsWritePermissionByView_0AsyncWithHttpInfo(viewId, permissions);

        }

        /// <summary>
        /// This call save permissions for a view 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">Id of the view</param>
        /// <param name="permissions">Permission to set</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ViewsPermissionsWritePermissionByView_0AsyncWithHttpInfo (string viewId, PermissionsDTO permissions)
        {
            // verify the required parameter 'viewId' is set
            if (viewId == null)
                throw new ApiException(400, "Missing required parameter 'viewId' when calling ViewsPermissionsApi->ViewsPermissionsWritePermissionByView_0");
            // verify the required parameter 'permissions' is set
            if (permissions == null)
                throw new ApiException(400, "Missing required parameter 'permissions' when calling ViewsPermissionsApi->ViewsPermissionsWritePermissionByView_0");

            var localVarPath = "/api/ViewsPermissions/{viewId}";
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
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (viewId != null) localVarPathParams.Add("viewId", Configuration.ApiClient.ParameterToString(viewId)); // path parameter
            if (permissions != null && permissions.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(permissions); // http body (model) parameter
            }
            else
            {
                localVarPostBody = permissions; // byte array
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
                Exception exception = ExceptionFactory("ViewsPermissionsWritePermissionByView_0", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

    }
}
