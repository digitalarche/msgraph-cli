using ApiSdk.Models.ODataErrors;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Cli.Commons.IO;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ApiSdk.Privacy.SubjectRightsRequests.Item.MicrosoftGraphGetFinalAttachment {
    /// <summary>
    /// Provides operations to call the getFinalAttachment method.
    /// </summary>
    public class GetFinalAttachmentRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Invoke function getFinalAttachment
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Invoke function getFinalAttachment";
            // Create options for all the parameters
            var subjectRightsRequestIdOption = new Option<string>("--subject-rights-request-id", description: "key: id of subjectRightsRequest") {
            };
            subjectRightsRequestIdOption.IsRequired = true;
            command.AddOption(subjectRightsRequestIdOption);
            var fileOption = new Option<FileInfo>("--file");
            command.AddOption(fileOption);
            command.SetHandler(async (invocationContext) => {
                var subjectRightsRequestId = invocationContext.ParseResult.GetValueForOption(subjectRightsRequestIdOption);
                var file = invocationContext.ParseResult.GetValueForOption(fileOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var requestInfo = ToGetRequestInformation(q => {
                });
                if (subjectRightsRequestId is not null) requestInfo.PathParameters.Add("subjectRightsRequest%2Did", subjectRightsRequestId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                if (file == null) {
                    using var reader = new StreamReader(response);
                    var strContent = reader.ReadToEnd();
                    Console.Write(strContent);
                }
                else {
                    using var writeStream = file.OpenWrite();
                    await response.CopyToAsync(writeStream);
                    Console.WriteLine($"Content written to {file.FullName}.");
                }
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new GetFinalAttachmentRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetFinalAttachmentRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/privacy/subjectRightsRequests/{subjectRightsRequest%2Did}/microsoft.graph.getFinalAttachment()";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Invoke function getFinalAttachment
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<GetFinalAttachmentRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<GetFinalAttachmentRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new GetFinalAttachmentRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class GetFinalAttachmentRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new getFinalAttachmentRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public GetFinalAttachmentRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}