// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class SignIn : Entity, IParsable {
        /// <summary>App name displayed in the Microsoft Entra admin center.  Supports $filter (eq, startsWith).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppDisplayName { get; set; }
#nullable restore
#else
        public string AppDisplayName { get; set; }
#endif
        /// <summary>Unique GUID representing the app ID in the Microsoft Entra ID.  Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppId { get; set; }
#nullable restore
#else
        public string AppId { get; set; }
#endif
        /// <summary>Provides a list of conditional access policies that are triggered by the corresponding sign-in activity. Apps need additional Conditional Access-related privileges to read the details of this property. For more information, see Viewing applied conditional access (CA) policies in sign-ins.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AppliedConditionalAccessPolicy>? AppliedConditionalAccessPolicies { get; set; }
#nullable restore
#else
        public List<AppliedConditionalAccessPolicy> AppliedConditionalAccessPolicies { get; set; }
#endif
        /// <summary>Identifies the client used for the sign-in activity. Modern authentication clients include Browser, modern clients. Legacy authentication clients include Exchange ActiveSync, IMAP, MAPI, SMTP, POP, and other clients.  Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientAppUsed { get; set; }
#nullable restore
#else
        public string ClientAppUsed { get; set; }
#endif
        /// <summary>Reports status of an activated conditional access policy. Possible values are: success, failure, notApplied, and unknownFutureValue.  Supports $filter (eq).</summary>
        public ApiSdk.Models.ConditionalAccessStatus? ConditionalAccessStatus { get; set; }
        /// <summary>The request ID sent from the client when the sign-in is initiated; used to troubleshoot sign-in activity.  Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CorrelationId { get; set; }
#nullable restore
#else
        public string CorrelationId { get; set; }
#endif
        /// <summary>Date and time (UTC) the sign-in was initiated. Example: midnight on Jan 1, 2014 is reported as 2014-01-01T00:00:00Z.  Supports $orderby, $filter (eq, le, and ge).</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Device information from where the sign-in occurred; includes device ID, operating system, and browser.  Supports $filter (eq, startsWith) on browser and operatingSytem properties.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.DeviceDetail? DeviceDetail { get; set; }
#nullable restore
#else
        public ApiSdk.Models.DeviceDetail DeviceDetail { get; set; }
#endif
        /// <summary>IP address of the client used to sign in.  Supports $filter (eq, startsWith).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IpAddress { get; set; }
#nullable restore
#else
        public string IpAddress { get; set; }
#endif
        /// <summary>Indicates if a sign-in is interactive or not.</summary>
        public bool? IsInteractive { get; set; }
        /// <summary>Provides the city, state, and country code where the sign-in originated.  Supports $filter (eq, startsWith) on city, state, and countryOrRegion properties.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SignInLocation? Location { get; set; }
#nullable restore
#else
        public SignInLocation Location { get; set; }
#endif
        /// <summary>Name of the resource the user signed into.  Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceDisplayName { get; set; }
#nullable restore
#else
        public string ResourceDisplayName { get; set; }
#endif
        /// <summary>ID of the resource that the user signed into.  Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceId { get; set; }
#nullable restore
#else
        public string ResourceId { get; set; }
#endif
        /// <summary>Provides the &apos;reason&apos; behind a specific state of a risky user, sign-in or a risk event. The possible values are: none, adminGeneratedTemporaryPassword, userPerformedSecuredPasswordChange, userPerformedSecuredPasswordReset, adminConfirmedSigninSafe, aiConfirmedSigninSafe, userPassedMFADrivenByRiskBasedPolicy, adminDismissedAllRiskForUser, adminConfirmedSigninCompromised, unknownFutureValue. The value none means that no action has been performed on the user or sign-in so far.  Supports $filter (eq).Note: Details for this property require a Microsoft Entra ID P2 license. Other licenses return the value hidden.</summary>
        public ApiSdk.Models.RiskDetail? RiskDetail { get; set; }
        /// <summary>Risk event types associated with the sign-in. The possible values are: unlikelyTravel, anonymizedIPAddress, maliciousIPAddress, unfamiliarFeatures, malwareInfectedIPAddress, suspiciousIPAddress, leakedCredentials, investigationsThreatIntelligence,  generic, and unknownFutureValue.  Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RiskEventType?>? RiskEventTypes { get; set; }
#nullable restore
#else
        public List<RiskEventType?> RiskEventTypes { get; set; }
#endif
        /// <summary>The list of risk event types associated with the sign-in. Possible values: unlikelyTravel, anonymizedIPAddress, maliciousIPAddress, unfamiliarFeatures, malwareInfectedIPAddress, suspiciousIPAddress, leakedCredentials, investigationsThreatIntelligence,  generic, or unknownFutureValue.  Supports $filter (eq, startsWith).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RiskEventTypes_v2 { get; set; }
#nullable restore
#else
        public List<string> RiskEventTypes_v2 { get; set; }
#endif
        /// <summary>Aggregated risk level. The possible values are: none, low, medium, high, hidden, and unknownFutureValue. The value hidden means the user or sign-in wasn&apos;t enabled for Microsoft Entra ID Protection.  Supports $filter (eq).  Note: Details for this property are only available for Microsoft Entra ID P2 customers. All other customers are returned hidden.</summary>
        public RiskLevel? RiskLevelAggregated { get; set; }
        /// <summary>Risk level during sign-in. The possible values are: none, low, medium, high, hidden, and unknownFutureValue. The value hidden means the user or sign-in wasn&apos;t enabled for Microsoft Entra ID Protection.  Supports $filter (eq).  Note: Details for this property are only available for Microsoft Entra ID P2 customers. All other customers are returned hidden.</summary>
        public RiskLevel? RiskLevelDuringSignIn { get; set; }
        /// <summary>Reports status of the risky user, sign-in, or a risk event. The possible values are: none, confirmedSafe, remediated, dismissed, atRisk, confirmedCompromised, unknownFutureValue.  Supports $filter (eq).</summary>
        public ApiSdk.Models.RiskState? RiskState { get; set; }
        /// <summary>Sign-in status. Includes the error code and description of the error (if there&apos;s a sign-in failure).  Supports $filter (eq) on errorCode property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SignInStatus? Status { get; set; }
#nullable restore
#else
        public SignInStatus Status { get; set; }
#endif
        /// <summary>Display name of the user that initiated the sign-in.  Supports $filter (eq, startsWith).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserDisplayName { get; set; }
#nullable restore
#else
        public string UserDisplayName { get; set; }
#endif
        /// <summary>ID of the user that initiated the sign-in.  Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId { get; set; }
#nullable restore
#else
        public string UserId { get; set; }
#endif
        /// <summary>User principal name of the user that initiated the sign-in.  Supports $filter (eq, startsWith).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserPrincipalName { get; set; }
#nullable restore
#else
        public string UserPrincipalName { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SignIn CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SignIn();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appDisplayName", n => { AppDisplayName = n.GetStringValue(); } },
                {"appId", n => { AppId = n.GetStringValue(); } },
                {"appliedConditionalAccessPolicies", n => { AppliedConditionalAccessPolicies = n.GetCollectionOfObjectValues<AppliedConditionalAccessPolicy>(AppliedConditionalAccessPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"clientAppUsed", n => { ClientAppUsed = n.GetStringValue(); } },
                {"conditionalAccessStatus", n => { ConditionalAccessStatus = n.GetEnumValue<ConditionalAccessStatus>(); } },
                {"correlationId", n => { CorrelationId = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"deviceDetail", n => { DeviceDetail = n.GetObjectValue<ApiSdk.Models.DeviceDetail>(ApiSdk.Models.DeviceDetail.CreateFromDiscriminatorValue); } },
                {"ipAddress", n => { IpAddress = n.GetStringValue(); } },
                {"isInteractive", n => { IsInteractive = n.GetBoolValue(); } },
                {"location", n => { Location = n.GetObjectValue<SignInLocation>(SignInLocation.CreateFromDiscriminatorValue); } },
                {"resourceDisplayName", n => { ResourceDisplayName = n.GetStringValue(); } },
                {"resourceId", n => { ResourceId = n.GetStringValue(); } },
                {"riskDetail", n => { RiskDetail = n.GetEnumValue<RiskDetail>(); } },
                {"riskEventTypes", n => { RiskEventTypes = n.GetCollectionOfEnumValues<RiskEventType>()?.ToList(); } },
                {"riskEventTypes_v2", n => { RiskEventTypes_v2 = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"riskLevelAggregated", n => { RiskLevelAggregated = n.GetEnumValue<RiskLevel>(); } },
                {"riskLevelDuringSignIn", n => { RiskLevelDuringSignIn = n.GetEnumValue<RiskLevel>(); } },
                {"riskState", n => { RiskState = n.GetEnumValue<RiskState>(); } },
                {"status", n => { Status = n.GetObjectValue<SignInStatus>(SignInStatus.CreateFromDiscriminatorValue); } },
                {"userDisplayName", n => { UserDisplayName = n.GetStringValue(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appDisplayName", AppDisplayName);
            writer.WriteStringValue("appId", AppId);
            writer.WriteCollectionOfObjectValues<AppliedConditionalAccessPolicy>("appliedConditionalAccessPolicies", AppliedConditionalAccessPolicies);
            writer.WriteStringValue("clientAppUsed", ClientAppUsed);
            writer.WriteEnumValue<ConditionalAccessStatus>("conditionalAccessStatus", ConditionalAccessStatus);
            writer.WriteStringValue("correlationId", CorrelationId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<ApiSdk.Models.DeviceDetail>("deviceDetail", DeviceDetail);
            writer.WriteStringValue("ipAddress", IpAddress);
            writer.WriteBoolValue("isInteractive", IsInteractive);
            writer.WriteObjectValue<SignInLocation>("location", Location);
            writer.WriteStringValue("resourceDisplayName", ResourceDisplayName);
            writer.WriteStringValue("resourceId", ResourceId);
            writer.WriteEnumValue<RiskDetail>("riskDetail", RiskDetail);
            writer.WriteCollectionOfEnumValues<RiskEventType>("riskEventTypes", RiskEventTypes);
            writer.WriteCollectionOfPrimitiveValues<string>("riskEventTypes_v2", RiskEventTypes_v2);
            writer.WriteEnumValue<RiskLevel>("riskLevelAggregated", RiskLevelAggregated);
            writer.WriteEnumValue<RiskLevel>("riskLevelDuringSignIn", RiskLevelDuringSignIn);
            writer.WriteEnumValue<RiskState>("riskState", RiskState);
            writer.WriteObjectValue<SignInStatus>("status", Status);
            writer.WriteStringValue("userDisplayName", UserDisplayName);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
