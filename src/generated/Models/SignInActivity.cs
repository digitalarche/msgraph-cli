// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class SignInActivity : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The last non-interactive sign-in date for a specific user. You can use this field to calculate the last time a client attempted (either successfully or unsuccessfully) to sign in to the directory on behalf of a user. Because some users may use clients to access tenant resources rather than signing into your tenant directly, you can use the non-interactive sign-in date to along with lastSignInDateTime to identify inactive users. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Microsoft Entra ID maintains non-interactive sign-ins going back to May 2020. For more information about using the value of this property, see Manage inactive user accounts in Microsoft Entra ID.</summary>
        public DateTimeOffset? LastNonInteractiveSignInDateTime { get; set; }
        /// <summary>Request identifier of the last non-interactive sign-in performed by this user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastNonInteractiveSignInRequestId { get; set; }
#nullable restore
#else
        public string LastNonInteractiveSignInRequestId { get; set; }
#endif
        /// <summary>The last interactive sign-in date and time for a specific user. You can use this field to calculate the last time a user attempted (either successfully or unsuccessfully) to sign in to the directory with an interactive authentication method. This field can be used to build reports, such as inactive users. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Microsoft Entra ID maintains interactive sign-ins going back to April 2020. For more information about using the value of this property, see Manage inactive user accounts in Microsoft Entra ID.</summary>
        public DateTimeOffset? LastSignInDateTime { get; set; }
        /// <summary>Request identifier of the last interactive sign-in performed by this user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastSignInRequestId { get; set; }
#nullable restore
#else
        public string LastSignInRequestId { get; set; }
#endif
        /// <summary>The date and time of the user&apos;s most recent successful sign-in activity. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastSuccessfulSignInDateTime { get; set; }
        /// <summary>The request ID of the last successful sign-in.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastSuccessfulSignInRequestId { get; set; }
#nullable restore
#else
        public string LastSuccessfulSignInRequestId { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="SignInActivity"/> and sets the default values.
        /// </summary>
        public SignInActivity()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="SignInActivity"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SignInActivity CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SignInActivity();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "lastNonInteractiveSignInDateTime", n => { LastNonInteractiveSignInDateTime = n.GetDateTimeOffsetValue(); } },
                { "lastNonInteractiveSignInRequestId", n => { LastNonInteractiveSignInRequestId = n.GetStringValue(); } },
                { "lastSignInDateTime", n => { LastSignInDateTime = n.GetDateTimeOffsetValue(); } },
                { "lastSignInRequestId", n => { LastSignInRequestId = n.GetStringValue(); } },
                { "lastSuccessfulSignInDateTime", n => { LastSuccessfulSignInDateTime = n.GetDateTimeOffsetValue(); } },
                { "lastSuccessfulSignInRequestId", n => { LastSuccessfulSignInRequestId = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("lastNonInteractiveSignInDateTime", LastNonInteractiveSignInDateTime);
            writer.WriteStringValue("lastNonInteractiveSignInRequestId", LastNonInteractiveSignInRequestId);
            writer.WriteDateTimeOffsetValue("lastSignInDateTime", LastSignInDateTime);
            writer.WriteStringValue("lastSignInRequestId", LastSignInRequestId);
            writer.WriteDateTimeOffsetValue("lastSuccessfulSignInDateTime", LastSuccessfulSignInDateTime);
            writer.WriteStringValue("lastSuccessfulSignInRequestId", LastSuccessfulSignInRequestId);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
