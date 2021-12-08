using ApiSdk.Models.Microsoft.Graph;
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
namespace ApiSdk.Me.CalendarGroups.Item.Calendars.Item.CalendarPermissions.Item {
    /// <summary>Builds and executes requests for operations under \me\calendarGroups\{calendarGroup-id}\calendars\{calendar-id}\calendarPermissions\{calendarPermission-id}</summary>
    public class CalendarPermissionRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// The permissions of the users with whom the calendar is shared.
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "The permissions of the users with whom the calendar is shared.";
            // Create options for all the parameters
            command.AddOption(new Option<string>("--calendargroup-id", description: "key: id of calendarGroup"));
            command.AddOption(new Option<string>("--calendar-id", description: "key: id of calendar"));
            command.AddOption(new Option<string>("--calendarpermission-id", description: "key: id of calendarPermission"));
            command.Handler = CommandHandler.Create<string, string, string>(async (calendarGroupId, calendarId, calendarPermissionId) => {
                var requestInfo = CreateDeleteRequestInformation();
                if (!String.IsNullOrEmpty(calendarGroupId)) requestInfo.PathParameters.Add("calendarGroup_id", calendarGroupId);
                if (!String.IsNullOrEmpty(calendarId)) requestInfo.PathParameters.Add("calendar_id", calendarId);
                if (!String.IsNullOrEmpty(calendarPermissionId)) requestInfo.PathParameters.Add("calendarPermission_id", calendarPermissionId);
                await RequestAdapter.SendNoContentAsync(requestInfo);
                // Print request output. What if the request has no return?
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// The permissions of the users with whom the calendar is shared.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "The permissions of the users with whom the calendar is shared.";
            // Create options for all the parameters
            command.AddOption(new Option<string>("--calendargroup-id", description: "key: id of calendarGroup"));
            command.AddOption(new Option<string>("--calendar-id", description: "key: id of calendar"));
            command.AddOption(new Option<string>("--calendarpermission-id", description: "key: id of calendarPermission"));
            command.AddOption(new Option<object>("--select", description: "Select properties to be returned"));
            command.Handler = CommandHandler.Create<string, string, string, object>(async (calendarGroupId, calendarId, calendarPermissionId, select) => {
                var requestInfo = CreateGetRequestInformation();
                if (!String.IsNullOrEmpty(calendarGroupId)) requestInfo.PathParameters.Add("calendarGroup_id", calendarGroupId);
                if (!String.IsNullOrEmpty(calendarId)) requestInfo.PathParameters.Add("calendar_id", calendarId);
                if (!String.IsNullOrEmpty(calendarPermissionId)) requestInfo.PathParameters.Add("calendarPermission_id", calendarPermissionId);
                requestInfo.QueryParameters.Add("select", select);
                var result = await RequestAdapter.SendAsync<CalendarPermission>(requestInfo);
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
        /// <summary>
        /// The permissions of the users with whom the calendar is shared.
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "The permissions of the users with whom the calendar is shared.";
            // Create options for all the parameters
            command.AddOption(new Option<string>("--calendargroup-id", description: "key: id of calendarGroup"));
            command.AddOption(new Option<string>("--calendar-id", description: "key: id of calendar"));
            command.AddOption(new Option<string>("--calendarpermission-id", description: "key: id of calendarPermission"));
            command.AddOption(new Option<string>("--body"));
            command.Handler = CommandHandler.Create<string, string, string, string>(async (calendarGroupId, calendarId, calendarPermissionId, body) => {
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<CalendarPermission>();
                var requestInfo = CreatePatchRequestInformation(model);
                if (!String.IsNullOrEmpty(calendarGroupId)) requestInfo.PathParameters.Add("calendarGroup_id", calendarGroupId);
                if (!String.IsNullOrEmpty(calendarId)) requestInfo.PathParameters.Add("calendar_id", calendarId);
                if (!String.IsNullOrEmpty(calendarPermissionId)) requestInfo.PathParameters.Add("calendarPermission_id", calendarPermissionId);
                await RequestAdapter.SendNoContentAsync(requestInfo);
                // Print request output. What if the request has no return?
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new CalendarPermissionRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public CalendarPermissionRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/me/calendarGroups/{calendarGroup_id}/calendars/{calendar_id}/calendarPermissions/{calendarPermission_id}{?select}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// The permissions of the users with whom the calendar is shared.
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
        /// The permissions of the users with whom the calendar is shared.
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
        /// The permissions of the users with whom the calendar is shared.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(CalendarPermission body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// The permissions of the users with whom the calendar is shared.
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
        /// The permissions of the users with whom the calendar is shared.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<CalendarPermission> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<CalendarPermission>(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// The permissions of the users with whom the calendar is shared.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="model"></param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(CalendarPermission model, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = model ?? throw new ArgumentNullException(nameof(model));
            var requestInfo = CreatePatchRequestInformation(model, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>The permissions of the users with whom the calendar is shared.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}