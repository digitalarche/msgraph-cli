// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class Simulation : Entity, IParsable {
        /// <summary>The social engineering technique used in the attack simulation and training campaign. Supports $filter and $orderby. Possible values are: unknown, credentialHarvesting, attachmentMalware, driveByUrl, linkInAttachment, linkToMalwareFile, unknownFutureValue, oAuthConsentGrant. Note that you must use the Prefer: include-unknown-enum-members request header to get the following values from this evolvable enum: oAuthConsentGrant. For more information on the types of social engineering attack techniques, see simulations.</summary>
        public SimulationAttackTechnique? AttackTechnique { get; set; }
        /// <summary>Attack type of the attack simulation and training campaign. Supports $filter and $orderby. Possible values are: unknown, social, cloud, endpoint, unknownFutureValue.</summary>
        public SimulationAttackType? AttackType { get; set; }
        /// <summary>Unique identifier for the attack simulation automation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AutomationId { get; set; }
#nullable restore
#else
        public string AutomationId { get; set; }
#endif
        /// <summary>Date and time of completion of the attack simulation and training campaign. Supports $filter and $orderby.</summary>
        public DateTimeOffset? CompletionDateTime { get; set; }
        /// <summary>Identity of the user who created the attack simulation and training campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EmailIdentity? CreatedBy { get; set; }
#nullable restore
#else
        public EmailIdentity CreatedBy { get; set; }
#endif
        /// <summary>Date and time of creation of the attack simulation and training campaign.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Description of the attack simulation and training campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Display name of the attack simulation and training campaign. Supports $filter and $orderby.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Simulation duration in days.</summary>
        public int? DurationInDays { get; set; }
        /// <summary>Details about the end user notification setting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.EndUserNotificationSetting? EndUserNotificationSetting { get; set; }
#nullable restore
#else
        public ApiSdk.Models.EndUserNotificationSetting EndUserNotificationSetting { get; set; }
#endif
        /// <summary>Users excluded from the simulation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AccountTargetContent? ExcludedAccountTarget { get; set; }
#nullable restore
#else
        public AccountTargetContent ExcludedAccountTarget { get; set; }
#endif
        /// <summary>Users targeted in the simulation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AccountTargetContent? IncludedAccountTarget { get; set; }
#nullable restore
#else
        public AccountTargetContent IncludedAccountTarget { get; set; }
#endif
        /// <summary>Flag that represents if the attack simulation and training campaign was created from a simulation automation flow. Supports $filter and $orderby.</summary>
        public bool? IsAutomated { get; set; }
        /// <summary>The landing page associated with a simulation during its creation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.LandingPage? LandingPage { get; set; }
#nullable restore
#else
        public ApiSdk.Models.LandingPage LandingPage { get; set; }
#endif
        /// <summary>Identity of the user who most recently modified the attack simulation and training campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EmailIdentity? LastModifiedBy { get; set; }
#nullable restore
#else
        public EmailIdentity LastModifiedBy { get; set; }
#endif
        /// <summary>Date and time of the most recent modification of the attack simulation and training campaign.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Date and time of the launch/start of the attack simulation and training campaign. Supports $filter and $orderby.</summary>
        public DateTimeOffset? LaunchDateTime { get; set; }
        /// <summary>The login page associated with a simulation during its creation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.LoginPage? LoginPage { get; set; }
#nullable restore
#else
        public ApiSdk.Models.LoginPage LoginPage { get; set; }
#endif
        /// <summary>OAuth app details for the OAuth technique.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.OAuthConsentAppDetail? OAuthConsentAppDetail { get; set; }
#nullable restore
#else
        public ApiSdk.Models.OAuthConsentAppDetail OAuthConsentAppDetail { get; set; }
#endif
        /// <summary>The payload associated with a simulation during its creation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Payload? Payload { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Payload Payload { get; set; }
#endif
        /// <summary>Method of delivery of the phishing payload used in the attack simulation and training campaign. Possible values are: unknown, sms, email, teams, unknownFutureValue.</summary>
        public ApiSdk.Models.PayloadDeliveryPlatform? PayloadDeliveryPlatform { get; set; }
        /// <summary>Report of the attack simulation and training campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SimulationReport? Report { get; set; }
#nullable restore
#else
        public SimulationReport Report { get; set; }
#endif
        /// <summary>Status of the attack simulation and training campaign. Supports $filter and $orderby. Possible values are: unknown, draft, running, scheduled, succeeded, failed, cancelled, excluded, unknownFutureValue.</summary>
        public SimulationStatus? Status { get; set; }
        /// <summary>Details about the training settings for a simulation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.TrainingSetting? TrainingSetting { get; set; }
#nullable restore
#else
        public ApiSdk.Models.TrainingSetting TrainingSetting { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Simulation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Simulation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"attackTechnique", n => { AttackTechnique = n.GetEnumValue<SimulationAttackTechnique>(); } },
                {"attackType", n => { AttackType = n.GetEnumValue<SimulationAttackType>(); } },
                {"automationId", n => { AutomationId = n.GetStringValue(); } },
                {"completionDateTime", n => { CompletionDateTime = n.GetDateTimeOffsetValue(); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<EmailIdentity>(EmailIdentity.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"durationInDays", n => { DurationInDays = n.GetIntValue(); } },
                {"endUserNotificationSetting", n => { EndUserNotificationSetting = n.GetObjectValue<ApiSdk.Models.EndUserNotificationSetting>(ApiSdk.Models.EndUserNotificationSetting.CreateFromDiscriminatorValue); } },
                {"excludedAccountTarget", n => { ExcludedAccountTarget = n.GetObjectValue<AccountTargetContent>(AccountTargetContent.CreateFromDiscriminatorValue); } },
                {"includedAccountTarget", n => { IncludedAccountTarget = n.GetObjectValue<AccountTargetContent>(AccountTargetContent.CreateFromDiscriminatorValue); } },
                {"isAutomated", n => { IsAutomated = n.GetBoolValue(); } },
                {"landingPage", n => { LandingPage = n.GetObjectValue<ApiSdk.Models.LandingPage>(ApiSdk.Models.LandingPage.CreateFromDiscriminatorValue); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<EmailIdentity>(EmailIdentity.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"launchDateTime", n => { LaunchDateTime = n.GetDateTimeOffsetValue(); } },
                {"loginPage", n => { LoginPage = n.GetObjectValue<ApiSdk.Models.LoginPage>(ApiSdk.Models.LoginPage.CreateFromDiscriminatorValue); } },
                {"oAuthConsentAppDetail", n => { OAuthConsentAppDetail = n.GetObjectValue<ApiSdk.Models.OAuthConsentAppDetail>(ApiSdk.Models.OAuthConsentAppDetail.CreateFromDiscriminatorValue); } },
                {"payload", n => { Payload = n.GetObjectValue<ApiSdk.Models.Payload>(ApiSdk.Models.Payload.CreateFromDiscriminatorValue); } },
                {"payloadDeliveryPlatform", n => { PayloadDeliveryPlatform = n.GetEnumValue<PayloadDeliveryPlatform>(); } },
                {"report", n => { Report = n.GetObjectValue<SimulationReport>(SimulationReport.CreateFromDiscriminatorValue); } },
                {"status", n => { Status = n.GetEnumValue<SimulationStatus>(); } },
                {"trainingSetting", n => { TrainingSetting = n.GetObjectValue<ApiSdk.Models.TrainingSetting>(ApiSdk.Models.TrainingSetting.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<SimulationAttackTechnique>("attackTechnique", AttackTechnique);
            writer.WriteEnumValue<SimulationAttackType>("attackType", AttackType);
            writer.WriteStringValue("automationId", AutomationId);
            writer.WriteDateTimeOffsetValue("completionDateTime", CompletionDateTime);
            writer.WriteObjectValue<EmailIdentity>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteIntValue("durationInDays", DurationInDays);
            writer.WriteObjectValue<ApiSdk.Models.EndUserNotificationSetting>("endUserNotificationSetting", EndUserNotificationSetting);
            writer.WriteObjectValue<AccountTargetContent>("excludedAccountTarget", ExcludedAccountTarget);
            writer.WriteObjectValue<AccountTargetContent>("includedAccountTarget", IncludedAccountTarget);
            writer.WriteBoolValue("isAutomated", IsAutomated);
            writer.WriteObjectValue<ApiSdk.Models.LandingPage>("landingPage", LandingPage);
            writer.WriteObjectValue<EmailIdentity>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteDateTimeOffsetValue("launchDateTime", LaunchDateTime);
            writer.WriteObjectValue<ApiSdk.Models.LoginPage>("loginPage", LoginPage);
            writer.WriteObjectValue<ApiSdk.Models.OAuthConsentAppDetail>("oAuthConsentAppDetail", OAuthConsentAppDetail);
            writer.WriteObjectValue<ApiSdk.Models.Payload>("payload", Payload);
            writer.WriteEnumValue<PayloadDeliveryPlatform>("payloadDeliveryPlatform", PayloadDeliveryPlatform);
            writer.WriteObjectValue<SimulationReport>("report", Report);
            writer.WriteEnumValue<SimulationStatus>("status", Status);
            writer.WriteObjectValue<ApiSdk.Models.TrainingSetting>("trainingSetting", TrainingSetting);
        }
    }
}
