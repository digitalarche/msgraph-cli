// <auto-generated/>
using ApiSdk.IdentityGovernance.EntitlementManagement.AccessPackages.Item.AssignmentPolicies.Item.CustomExtensionStageSettings.Item.CustomExtension;
using ApiSdk.Models.ODataErrors;
using ApiSdk.Models;
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
namespace ApiSdk.IdentityGovernance.EntitlementManagement.AccessPackages.Item.AssignmentPolicies.Item.CustomExtensionStageSettings.Item {
    /// <summary>
    /// Provides operations to manage the customExtensionStageSettings property of the microsoft.graph.accessPackageAssignmentPolicy entity.
    /// </summary>
    public class CustomExtensionStageSettingItemRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Provides operations to manage the customExtension property of the microsoft.graph.customExtensionStageSetting entity.
        /// </summary>
        public Command BuildCustomExtensionNavCommand() {
            var command = new Command("custom-extension");
            command.Description = "Provides operations to manage the customExtension property of the microsoft.graph.customExtensionStageSetting entity.";
            var builder = new CustomExtensionRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Delete navigation property customExtensionStageSettings for identityGovernance
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Delete navigation property customExtensionStageSettings for identityGovernance";
            var accessPackageIdOption = new Option<string>("--access-package-id", description: "The unique identifier of accessPackage") {
            };
            accessPackageIdOption.IsRequired = true;
            command.AddOption(accessPackageIdOption);
            var accessPackageAssignmentPolicyIdOption = new Option<string>("--access-package-assignment-policy-id", description: "The unique identifier of accessPackageAssignmentPolicy") {
            };
            accessPackageAssignmentPolicyIdOption.IsRequired = true;
            command.AddOption(accessPackageAssignmentPolicyIdOption);
            var customExtensionStageSettingIdOption = new Option<string>("--custom-extension-stage-setting-id", description: "The unique identifier of customExtensionStageSetting") {
            };
            customExtensionStageSettingIdOption.IsRequired = true;
            command.AddOption(customExtensionStageSettingIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var accessPackageId = invocationContext.ParseResult.GetValueForOption(accessPackageIdOption);
                var accessPackageAssignmentPolicyId = invocationContext.ParseResult.GetValueForOption(accessPackageAssignmentPolicyIdOption);
                var customExtensionStageSettingId = invocationContext.ParseResult.GetValueForOption(customExtensionStageSettingIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (accessPackageId is not null) requestInfo.PathParameters.Add("accessPackage%2Did", accessPackageId);
                if (accessPackageAssignmentPolicyId is not null) requestInfo.PathParameters.Add("accessPackageAssignmentPolicy%2Did", accessPackageAssignmentPolicyId);
                if (customExtensionStageSettingId is not null) requestInfo.PathParameters.Add("customExtensionStageSetting%2Did", customExtensionStageSettingId);
                if (ifMatch is not null) requestInfo.Headers.Add("If-Match", ifMatch);
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
        /// The collection of stages when to execute one or more custom access package workflow extensions. Supports $expand.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "The collection of stages when to execute one or more custom access package workflow extensions. Supports $expand.";
            var accessPackageIdOption = new Option<string>("--access-package-id", description: "The unique identifier of accessPackage") {
            };
            accessPackageIdOption.IsRequired = true;
            command.AddOption(accessPackageIdOption);
            var accessPackageAssignmentPolicyIdOption = new Option<string>("--access-package-assignment-policy-id", description: "The unique identifier of accessPackageAssignmentPolicy") {
            };
            accessPackageAssignmentPolicyIdOption.IsRequired = true;
            command.AddOption(accessPackageAssignmentPolicyIdOption);
            var customExtensionStageSettingIdOption = new Option<string>("--custom-extension-stage-setting-id", description: "The unique identifier of customExtensionStageSetting") {
            };
            customExtensionStageSettingIdOption.IsRequired = true;
            command.AddOption(customExtensionStageSettingIdOption);
            var selectOption = new Option<string[]>("--select", description: "Select properties to be returned") {
                Arity = ArgumentArity.ZeroOrMore
            };
            selectOption.IsRequired = false;
            command.AddOption(selectOption);
            var expandOption = new Option<string[]>("--expand", description: "Expand related entities") {
                Arity = ArgumentArity.ZeroOrMore
            };
            expandOption.IsRequired = false;
            command.AddOption(expandOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var accessPackageId = invocationContext.ParseResult.GetValueForOption(accessPackageIdOption);
                var accessPackageAssignmentPolicyId = invocationContext.ParseResult.GetValueForOption(accessPackageAssignmentPolicyIdOption);
                var customExtensionStageSettingId = invocationContext.ParseResult.GetValueForOption(customExtensionStageSettingIdOption);
                var select = invocationContext.ParseResult.GetValueForOption(selectOption);
                var expand = invocationContext.ParseResult.GetValueForOption(expandOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                    q.QueryParameters.Select = select;
                    q.QueryParameters.Expand = expand;
                });
                if (accessPackageId is not null) requestInfo.PathParameters.Add("accessPackage%2Did", accessPackageId);
                if (accessPackageAssignmentPolicyId is not null) requestInfo.PathParameters.Add("accessPackageAssignmentPolicy%2Did", accessPackageAssignmentPolicyId);
                if (customExtensionStageSettingId is not null) requestInfo.PathParameters.Add("customExtensionStageSetting%2Did", customExtensionStageSettingId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Update the navigation property customExtensionStageSettings in identityGovernance
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Update the navigation property customExtensionStageSettings in identityGovernance";
            var accessPackageIdOption = new Option<string>("--access-package-id", description: "The unique identifier of accessPackage") {
            };
            accessPackageIdOption.IsRequired = true;
            command.AddOption(accessPackageIdOption);
            var accessPackageAssignmentPolicyIdOption = new Option<string>("--access-package-assignment-policy-id", description: "The unique identifier of accessPackageAssignmentPolicy") {
            };
            accessPackageAssignmentPolicyIdOption.IsRequired = true;
            command.AddOption(accessPackageAssignmentPolicyIdOption);
            var customExtensionStageSettingIdOption = new Option<string>("--custom-extension-stage-setting-id", description: "The unique identifier of customExtensionStageSetting") {
            };
            customExtensionStageSettingIdOption.IsRequired = true;
            command.AddOption(customExtensionStageSettingIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var accessPackageId = invocationContext.ParseResult.GetValueForOption(accessPackageIdOption);
                var accessPackageAssignmentPolicyId = invocationContext.ParseResult.GetValueForOption(accessPackageAssignmentPolicyIdOption);
                var customExtensionStageSettingId = invocationContext.ParseResult.GetValueForOption(customExtensionStageSettingIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<CustomExtensionStageSetting>(CustomExtensionStageSetting.CreateFromDiscriminatorValue);
                if (model is null) {
                    Console.Error.WriteLine("No model data to send.");
                    return;
                }
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (accessPackageId is not null) requestInfo.PathParameters.Add("accessPackage%2Did", accessPackageId);
                if (accessPackageAssignmentPolicyId is not null) requestInfo.PathParameters.Add("accessPackageAssignmentPolicy%2Did", accessPackageAssignmentPolicyId);
                if (customExtensionStageSettingId is not null) requestInfo.PathParameters.Add("customExtensionStageSetting%2Did", customExtensionStageSettingId);
                requestInfo.SetContentFromParsable(reqAdapter, "application/json", model);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new CustomExtensionStageSettingItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public CustomExtensionStageSettingItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/identityGovernance/entitlementManagement/accessPackages/{accessPackage%2Did}/assignmentPolicies/{accessPackageAssignmentPolicy%2Did}/customExtensionStageSettings/{customExtensionStageSetting%2Did}{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new CustomExtensionStageSettingItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public CustomExtensionStageSettingItemRequestBuilder(string rawUrl) : base("{+baseurl}/identityGovernance/entitlementManagement/accessPackages/{accessPackage%2Did}/assignmentPolicies/{accessPackageAssignmentPolicy%2Did}/customExtensionStageSettings/{customExtensionStageSetting%2Did}{?%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// Delete navigation property customExtensionStageSettings for identityGovernance
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// The collection of stages when to execute one or more custom access package workflow extensions. Supports $expand.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<CustomExtensionStageSettingItemRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<CustomExtensionStageSettingItemRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property customExtensionStageSettings in identityGovernance
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(CustomExtensionStageSetting body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(CustomExtensionStageSetting body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// The collection of stages when to execute one or more custom access package workflow extensions. Supports $expand.
        /// </summary>
        public class CustomExtensionStageSettingItemRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
    }
}
