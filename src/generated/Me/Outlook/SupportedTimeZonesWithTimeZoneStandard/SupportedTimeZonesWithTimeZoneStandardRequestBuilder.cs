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
namespace ApiSdk.Me.Outlook.SupportedTimeZonesWithTimeZoneStandard {
    /// <summary>Builds and executes requests for operations under \me\outlook\microsoft.graph.supportedTimeZones(TimeZoneStandard={TimeZoneStandard})</summary>
    public class SupportedTimeZonesWithTimeZoneStandardRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Invoke function supportedTimeZones
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Invoke function supportedTimeZones";
            // Create options for all the parameters
            command.AddOption(new Option<string>("--timezonestandard", description: "Usage: TimeZoneStandard={TimeZoneStandard}"));
            command.Handler = CommandHandler.Create<string>(async (TimeZoneStandard) => {
                var requestInfo = CreateGetRequestInformation();
                if (!String.IsNullOrEmpty(TimeZoneStandard)) requestInfo.PathParameters.Add("TimeZoneStandard", TimeZoneStandard);
                var result = await RequestAdapter.SendCollectionAsync<ApiSdk.Me.Outlook.SupportedTimeZonesWithTimeZoneStandard.SupportedTimeZonesWithTimeZoneStandard>(requestInfo);
                // Print request output. What if the request has no return?
                using var serializer = RequestAdapter.SerializationWriterFactory.GetSerializationWriter("application/json");
                serializer.WriteCollectionOfObjectValues(null, result);
                using var content = serializer.GetSerializedContent();
                using var reader = new StreamReader(content);
                var strContent = await reader.ReadToEndAsync();
                Console.Write(strContent + "\n");
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new SupportedTimeZonesWithTimeZoneStandardRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// <param name="TimeZoneStandard">Usage: TimeZoneStandard={TimeZoneStandard}</param>
        /// </summary>
        public SupportedTimeZonesWithTimeZoneStandardRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, string timeZoneStandard = default) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/me/outlook/microsoft.graph.supportedTimeZones(TimeZoneStandard={TimeZoneStandard})";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            urlTplParams.Add("TimeZoneStandard", timeZoneStandard);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Invoke function supportedTimeZones
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
        /// Invoke function supportedTimeZones
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<IEnumerable<ApiSdk.Me.Outlook.SupportedTimeZonesWithTimeZoneStandard.SupportedTimeZonesWithTimeZoneStandard>> GetAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(h, o);
            return await RequestAdapter.SendCollectionAsync<ApiSdk.Me.Outlook.SupportedTimeZonesWithTimeZoneStandard.SupportedTimeZonesWithTimeZoneStandard>(requestInfo, responseHandler, cancellationToken);
        }
    }
}