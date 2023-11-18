// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class PresenceStatusMessage : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Time in which the status message expires.If not provided, the status message doesn&apos;t expire.expiryDateTime.dateTime shouldn&apos;t include time zone.expiryDateTime isn&apos;t available when you request the presence of another user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DateTimeTimeZone? ExpiryDateTime { get; set; }
#nullable restore
#else
        public DateTimeTimeZone ExpiryDateTime { get; set; }
#endif
        /// <summary>Status message item. The only supported format currently is message.contentType = &apos;text&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ItemBody? Message { get; set; }
#nullable restore
#else
        public ItemBody Message { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Time in which the status message was published.Read-only.publishedDateTime isn&apos;t available when you request the presence of another user.</summary>
        public DateTimeOffset? PublishedDateTime { get; set; }
        /// <summary>
        /// Instantiates a new presenceStatusMessage and sets the default values.
        /// </summary>
        public PresenceStatusMessage() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PresenceStatusMessage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PresenceStatusMessage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"expiryDateTime", n => { ExpiryDateTime = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"message", n => { Message = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
                {"publishedDateTime", n => { PublishedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<DateTimeTimeZone>("expiryDateTime", ExpiryDateTime);
            writer.WriteObjectValue<ItemBody>("message", Message);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteDateTimeOffsetValue("publishedDateTime", PublishedDateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
