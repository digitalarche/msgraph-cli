using ApiSdk.Models.Microsoft.Graph;
using ApiSdk.PermissionGrants.GetAvailableExtensionProperties;
using ApiSdk.PermissionGrants.GetByIds;
using ApiSdk.PermissionGrants.Item;
using ApiSdk.PermissionGrants.ValidateProperties;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ApiSdk.PermissionGrants {
    /// <summary>Builds and executes requests for operations under \permissionGrants</summary>
    public class PermissionGrantsRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public List<Command> BuildCommand() {
            var builder = new ResourceSpecificPermissionGrantRequestBuilder(PathParameters, RequestAdapter);
            var commands = new List<Command> { 
                builder.BuildCheckMemberGroupsCommand(),
                builder.BuildCheckMemberObjectsCommand(),
                builder.BuildDeleteCommand(),
                builder.BuildGetCommand(),
                builder.BuildGetMemberGroupsCommand(),
                builder.BuildGetMemberObjectsCommand(),
                builder.BuildPatchCommand(),
                builder.BuildRestoreCommand(),
            };
            return commands;
        }
        /// <summary>
        /// Add new entity to permissionGrants
        /// </summary>
        public Command BuildCreateCommand() {
            var command = new Command("create");
            command.Description = "Add new entity to permissionGrants";
            // Create options for all the parameters
            command.AddOption(new Option<string>("--body"));
            command.Handler = CommandHandler.Create<string>(async (body) => {
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ResourceSpecificPermissionGrant>();
                var requestInfo = CreatePostRequestInformation(model);
                var result = await RequestAdapter.SendAsync<ResourceSpecificPermissionGrant>(requestInfo);
                // Print request output. What if the request has no return?
                using var serializer = RequestAdapter.SerializationWriterFactory.GetSerializationWriter("application/json");
                serializer.WriteObjectValue(null, result);
                using var content = serializer.GetSerializedContent();
                using var reader = new StreamReader(content);
                var strContent = await reader.ReadToEndAsync();
                Console.Write(strContent + "\n");
            });
            return command;
        }
        public Command BuildGetAvailableExtensionPropertiesCommand() {
            var command = new Command("get-available-extension-properties");
            var builder = new ApiSdk.PermissionGrants.GetAvailableExtensionProperties.GetAvailableExtensionPropertiesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildGetByIdsCommand() {
            var command = new Command("get-by-ids");
            var builder = new ApiSdk.PermissionGrants.GetByIds.GetByIdsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Get entities from permissionGrants
        /// </summary>
        public Command BuildListCommand() {
            var command = new Command("list");
            command.Description = "Get entities from permissionGrants";
            // Create options for all the parameters
            command.AddOption(new Option<string>("--search", description: "Search items by search phrases"));
            command.AddOption(new Option<string>("--filter", description: "Filter items by property values"));
            command.AddOption(new Option<object>("--orderby", description: "Order items by property values"));
            command.AddOption(new Option<object>("--select", description: "Select properties to be returned"));
            command.AddOption(new Option<object>("--expand", description: "Expand related entities"));
            command.Handler = CommandHandler.Create<string, string, object, object, object>(async (search, filter, orderby, select, expand) => {
                var requestInfo = CreateGetRequestInformation();
                if (!String.IsNullOrEmpty(search)) requestInfo.QueryParameters.Add("search", search);
                if (!String.IsNullOrEmpty(filter)) requestInfo.QueryParameters.Add("filter", filter);
                requestInfo.QueryParameters.Add("orderby", orderby);
                requestInfo.QueryParameters.Add("select", select);
                requestInfo.QueryParameters.Add("expand", expand);
                var result = await RequestAdapter.SendAsync<PermissionGrantsResponse>(requestInfo);
                // Print request output. What if the request has no return?
                using var serializer = RequestAdapter.SerializationWriterFactory.GetSerializationWriter("application/json");
                serializer.WriteObjectValue(null, result);
                using var content = serializer.GetSerializedContent();
                using var reader = new StreamReader(content);
                var strContent = await reader.ReadToEndAsync();
                Console.Write(strContent + "\n");
            });
            return command;
        }
        public Command BuildValidatePropertiesCommand() {
            var command = new Command("validate-properties");
            var builder = new ApiSdk.PermissionGrants.ValidateProperties.ValidatePropertiesRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new PermissionGrantsRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public PermissionGrantsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/permissionGrants{?search,filter,orderby,select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Get entities from permissionGrants
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (q != null) {
                var qParams = new GetQueryParameters();
                q.Invoke(qParams);
                qParams.AddQueryParameters(requestInfo.QueryParameters);
            }
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Add new entity to permissionGrants
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePostRequestInformation(ResourceSpecificPermissionGrant body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Get entities from permissionGrants
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<PermissionGrantsResponse> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<PermissionGrantsResponse>(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// Add new entity to permissionGrants
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="model"></param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<ResourceSpecificPermissionGrant> PostAsync(ResourceSpecificPermissionGrant model, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = model ?? throw new ArgumentNullException(nameof(model));
            var requestInfo = CreatePostRequestInformation(model, h, o);
            return await RequestAdapter.SendAsync<ResourceSpecificPermissionGrant>(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>Get entities from permissionGrants</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Filter items by property values</summary>
            public string Filter { get; set; }
            /// <summary>Order items by property values</summary>
            public string[] Orderby { get; set; }
            /// <summary>Search items by search phrases</summary>
            public string Search { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}