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
namespace ApiSdk.Subscriptions.Item.Reauthorize {
    /// <summary>
    /// Provides operations to call the reauthorize method.
    /// </summary>
    public class ReauthorizeRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Reauthorize a subscription when you receive a reauthorizationRequired challenge. This API is available in the following national cloud deployments.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/subscription-reauthorize?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildPostCommand() {
            var command = new Command("post");
            command.Description = "Reauthorize a subscription when you receive a reauthorizationRequired challenge. This API is available in the following national cloud deployments.\n\nFind more info here:\n  https://learn.microsoft.com/graph/api/subscription-reauthorize?view=graph-rest-1.0";
            var subscriptionIdOption = new Option<string>("--subscription-id", description: "The unique identifier of subscription") {
            };
            subscriptionIdOption.IsRequired = true;
            command.AddOption(subscriptionIdOption);
            command.SetHandler(async (invocationContext) => {
                var subscriptionId = invocationContext.ParseResult.GetValueForOption(subscriptionIdOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (subscriptionId is not null) requestInfo.PathParameters.Add("subscription%2Did", subscriptionId);
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
        /// Instantiates a new ReauthorizeRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public ReauthorizeRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/subscriptions/{subscription%2Did}/reauthorize", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ReauthorizeRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ReauthorizeRequestBuilder(string rawUrl) : base("{+baseurl}/subscriptions/{subscription%2Did}/reauthorize", rawUrl) {
        }
        /// <summary>
        /// Reauthorize a subscription when you receive a reauthorizationRequired challenge. This API is available in the following national cloud deployments.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
    }
}
