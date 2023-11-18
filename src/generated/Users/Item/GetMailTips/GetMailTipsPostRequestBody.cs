// <auto-generated/>
using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Users.Item.GetMailTips {
    public class GetMailTipsPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The EmailAddresses property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? EmailAddresses { get; set; }
#nullable restore
#else
        public List<string> EmailAddresses { get; set; }
#endif
        /// <summary>The MailTipsOptions property</summary>
        public MailTipsType? MailTipsOptions { get; set; }
        /// <summary>
        /// Instantiates a new getMailTipsPostRequestBody and sets the default values.
        /// </summary>
        public GetMailTipsPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static GetMailTipsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GetMailTipsPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"EmailAddresses", n => { EmailAddresses = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"MailTipsOptions", n => { MailTipsOptions = n.GetEnumValue<MailTipsType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("EmailAddresses", EmailAddresses);
            writer.WriteEnumValue<MailTipsType>("MailTipsOptions", MailTipsOptions);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
