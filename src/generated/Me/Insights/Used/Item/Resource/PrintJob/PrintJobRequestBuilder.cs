using ApiSdk.Me.Insights.Used.Item.Resource.PrintJob.Abort;
using ApiSdk.Me.Insights.Used.Item.Resource.PrintJob.Cancel;
using ApiSdk.Me.Insights.Used.Item.Resource.PrintJob.Redirect;
using ApiSdk.Me.Insights.Used.Item.Resource.PrintJob.Start;
using Microsoft.Kiota.Abstractions;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ApiSdk.Me.Insights.Used.Item.Resource.PrintJob {
    /// <summary>Builds and executes requests for operations under \me\insights\used\{usedInsight-id}\resource\microsoft.graph.printJob</summary>
    public class PrintJobRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public Command BuildAbortCommand() {
            var command = new Command("abort");
            var builder = new ApiSdk.Me.Insights.Used.Item.Resource.PrintJob.Abort.AbortRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildCancelCommand() {
            var command = new Command("cancel");
            var builder = new ApiSdk.Me.Insights.Used.Item.Resource.PrintJob.Cancel.CancelRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildRedirectCommand() {
            var command = new Command("redirect");
            var builder = new ApiSdk.Me.Insights.Used.Item.Resource.PrintJob.Redirect.RedirectRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        public Command BuildStartCommand() {
            var command = new Command("start");
            var builder = new ApiSdk.Me.Insights.Used.Item.Resource.PrintJob.Start.StartRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new PrintJobRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public PrintJobRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/me/insights/used/{usedInsight_id}/resource/microsoft.graph.printJob";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
    }
}