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
namespace ApiSdk.Identity.B2xUserFlows.Item.UserAttributeAssignments.Item.UserAttribute.@Ref {
    /// <summary>Builds and executes requests for operations under \identity\b2xUserFlows\{b2xIdentityUserFlow-id}\userAttributeAssignments\{identityUserFlowAttributeAssignment-id}\userAttribute\$ref</summary>
    public class RefRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// The user attribute that you want to add to your user flow.
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "The user attribute that you want to add to your user flow.";
            // Create options for all the parameters
            command.AddOption(new Option<string>("--b2xidentityuserflow-id", description: "key: id of b2xIdentityUserFlow"));
            command.AddOption(new Option<string>("--identityuserflowattributeassignment-id", description: "key: id of identityUserFlowAttributeAssignment"));
            command.Handler = CommandHandler.Create<string, string>(async (b2xIdentityUserFlowId, identityUserFlowAttributeAssignmentId) => {
                var requestInfo = CreateDeleteRequestInformation();
                if (!String.IsNullOrEmpty(b2xIdentityUserFlowId)) requestInfo.PathParameters.Add("b2xIdentityUserFlow_id", b2xIdentityUserFlowId);
                if (!String.IsNullOrEmpty(identityUserFlowAttributeAssignmentId)) requestInfo.PathParameters.Add("identityUserFlowAttributeAssignment_id", identityUserFlowAttributeAssignmentId);
                await RequestAdapter.SendNoContentAsync(requestInfo);
                // Print request output. What if the request has no return?
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// The user attribute that you want to add to your user flow.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "The user attribute that you want to add to your user flow.";
            // Create options for all the parameters
            command.AddOption(new Option<string>("--b2xidentityuserflow-id", description: "key: id of b2xIdentityUserFlow"));
            command.AddOption(new Option<string>("--identityuserflowattributeassignment-id", description: "key: id of identityUserFlowAttributeAssignment"));
            command.Handler = CommandHandler.Create<string, string>(async (b2xIdentityUserFlowId, identityUserFlowAttributeAssignmentId) => {
                var requestInfo = CreateGetRequestInformation();
                if (!String.IsNullOrEmpty(b2xIdentityUserFlowId)) requestInfo.PathParameters.Add("b2xIdentityUserFlow_id", b2xIdentityUserFlowId);
                if (!String.IsNullOrEmpty(identityUserFlowAttributeAssignmentId)) requestInfo.PathParameters.Add("identityUserFlowAttributeAssignment_id", identityUserFlowAttributeAssignmentId);
                var result = await RequestAdapter.SendPrimitiveAsync<string>(requestInfo);
                // Print request output. What if the request has no return?
                using var serializer = RequestAdapter.SerializationWriterFactory.GetSerializationWriter("application/json");
                serializer.WriteStringValue(null, result);
                using var content = serializer.GetSerializedContent();
                using var reader = new StreamReader(content);
                var strContent = await reader.ReadToEndAsync();
                Console.Write(strContent + "\n");
            });
            return command;
        }
        /// <summary>
        /// The user attribute that you want to add to your user flow.
        /// </summary>
        public Command BuildPutCommand() {
            var command = new Command("put");
            command.Description = "The user attribute that you want to add to your user flow.";
            // Create options for all the parameters
            command.AddOption(new Option<string>("--b2xidentityuserflow-id", description: "key: id of b2xIdentityUserFlow"));
            command.AddOption(new Option<string>("--identityuserflowattributeassignment-id", description: "key: id of identityUserFlowAttributeAssignment"));
            command.AddOption(new Option<string>("--body"));
            command.Handler = CommandHandler.Create<string, string, string>(async (b2xIdentityUserFlowId, identityUserFlowAttributeAssignmentId, body) => {
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ApiSdk.Identity.B2xUserFlows.Item.UserAttributeAssignments.Item.UserAttribute.@Ref.@Ref>();
                var requestInfo = CreatePutRequestInformation(model);
                if (!String.IsNullOrEmpty(b2xIdentityUserFlowId)) requestInfo.PathParameters.Add("b2xIdentityUserFlow_id", b2xIdentityUserFlowId);
                if (!String.IsNullOrEmpty(identityUserFlowAttributeAssignmentId)) requestInfo.PathParameters.Add("identityUserFlowAttributeAssignment_id", identityUserFlowAttributeAssignmentId);
                await RequestAdapter.SendNoContentAsync(requestInfo);
                // Print request output. What if the request has no return?
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new RefRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public RefRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/identity/b2xUserFlows/{b2xIdentityUserFlow_id}/userAttributeAssignments/{identityUserFlowAttributeAssignment_id}/userAttribute/$ref";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// The user attribute that you want to add to your user flow.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// The user attribute that you want to add to your user flow.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// The user attribute that you want to add to your user flow.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePutRequestInformation(ApiSdk.Identity.B2xUserFlows.Item.UserAttributeAssignments.Item.UserAttribute.@Ref.@Ref body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.PUT,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// The user attribute that you want to add to your user flow.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// The user attribute that you want to add to your user flow.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<string> GetAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(h, o);
            return await RequestAdapter.SendPrimitiveAsync<string>(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// The user attribute that you want to add to your user flow.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="model"></param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PutAsync(ApiSdk.Identity.B2xUserFlows.Item.UserAttributeAssignments.Item.UserAttribute.@Ref.@Ref model, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = model ?? throw new ArgumentNullException(nameof(model));
            var requestInfo = CreatePutRequestInformation(model, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, cancellationToken);
        }
    }
}