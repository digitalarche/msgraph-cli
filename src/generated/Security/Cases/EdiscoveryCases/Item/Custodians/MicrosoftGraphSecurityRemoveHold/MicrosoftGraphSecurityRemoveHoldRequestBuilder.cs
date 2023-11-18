// <auto-generated/>
using ApiSdk.Models.ODataErrors;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Cli.Commons.Extensions;
using Microsoft.Kiota.Cli.Commons.IO;
using Microsoft.Kiota.Cli.Commons;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace ApiSdk.Security.Cases.EdiscoveryCases.Item.Custodians.MicrosoftGraphSecurityRemoveHold {
    /// <summary>
    /// Provides operations to call the removeHold method.
    /// </summary>
    public class MicrosoftGraphSecurityRemoveHoldRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Invoke action removeHold
        /// </summary>
        public Command BuildPostCommand() {
            var command = new Command("post");
            command.Description = "Invoke action removeHold";
            var ediscoveryCaseIdOption = new Option<string>("--ediscovery-case-id", description: "The unique identifier of ediscoveryCase") {
            };
            ediscoveryCaseIdOption.IsRequired = true;
            command.AddOption(ediscoveryCaseIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (invocationContext) => {
                var ediscoveryCaseId = invocationContext.ParseResult.GetValueForOption(ediscoveryCaseIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<RemoveHoldPostRequestBody>(RemoveHoldPostRequestBody.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPostRequestInformation(model, q => {
                });
                if (ediscoveryCaseId is not null) requestInfo.PathParameters.Add("ediscoveryCase%2Did", ediscoveryCaseId);
                requestInfo.SetContentFromParsable(reqAdapter, "application/json", model);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                await reqAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new MicrosoftGraphSecurityRemoveHoldRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public MicrosoftGraphSecurityRemoveHoldRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/security/cases/ediscoveryCases/{ediscoveryCase%2Did}/custodians/microsoft.graph.security.removeHold", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new MicrosoftGraphSecurityRemoveHoldRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public MicrosoftGraphSecurityRemoveHoldRequestBuilder(string rawUrl) : base("{+baseurl}/security/cases/ediscoveryCases/{ediscoveryCase%2Did}/custodians/microsoft.graph.security.removeHold", rawUrl) {
        }
        /// <summary>
        /// Invoke action removeHold
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(RemoveHoldPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(RemoveHoldPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
    }
}
