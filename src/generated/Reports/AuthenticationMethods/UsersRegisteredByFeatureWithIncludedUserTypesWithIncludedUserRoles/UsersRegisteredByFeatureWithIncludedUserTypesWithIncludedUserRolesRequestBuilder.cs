// <auto-generated/>
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
namespace ApiSdk.Reports.AuthenticationMethods.UsersRegisteredByFeatureWithIncludedUserTypesWithIncludedUserRoles {
    /// <summary>
    /// Provides operations to call the usersRegisteredByFeature method.
    /// </summary>
    public class UsersRegisteredByFeatureWithIncludedUserTypesWithIncludedUserRolesRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Invoke function usersRegisteredByFeature
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Invoke function usersRegisteredByFeature";
            var includedUserTypesOption = new Option<object>("--included-user-types", description: "Usage: includedUserTypes='{includedUserTypes}'") {
            };
            includedUserTypesOption.IsRequired = true;
            command.AddOption(includedUserTypesOption);
            var includedUserRolesOption = new Option<object>("--included-user-roles", description: "Usage: includedUserRoles='{includedUserRoles}'") {
            };
            includedUserRolesOption.IsRequired = true;
            command.AddOption(includedUserRolesOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON);
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            command.SetHandler(async (invocationContext) => {
                var includedUserTypes = invocationContext.ParseResult.GetValueForOption(includedUserTypesOption);
                var includedUserRoles = invocationContext.ParseResult.GetValueForOption(includedUserRolesOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                });
                if (includedUserTypes is not null) requestInfo.PathParameters.Add("includedUserTypes", includedUserTypes);
                if (includedUserRoles is not null) requestInfo.PathParameters.Add("includedUserRoles", includedUserRoles);
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
        /// Instantiates a new UsersRegisteredByFeatureWithIncludedUserTypesWithIncludedUserRolesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public UsersRegisteredByFeatureWithIncludedUserTypesWithIncludedUserRolesRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/reports/authenticationMethods/usersRegisteredByFeature(includedUserTypes='{includedUserTypes}',includedUserRoles='{includedUserRoles}')", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new UsersRegisteredByFeatureWithIncludedUserTypesWithIncludedUserRolesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public UsersRegisteredByFeatureWithIncludedUserTypesWithIncludedUserRolesRequestBuilder(string rawUrl) : base("{+baseurl}/reports/authenticationMethods/usersRegisteredByFeature(includedUserTypes='{includedUserTypes}',includedUserRoles='{includedUserRoles}')", rawUrl) {
        }
        /// <summary>
        /// Invoke function usersRegisteredByFeature
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
    }
}
