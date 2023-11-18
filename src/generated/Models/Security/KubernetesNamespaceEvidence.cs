// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.Security {
    public class KubernetesNamespaceEvidence : AlertEvidence, IParsable {
        /// <summary>The namespace cluster.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KubernetesClusterEvidence? Cluster { get; set; }
#nullable restore
#else
        public KubernetesClusterEvidence Cluster { get; set; }
#endif
        /// <summary>The labels for the Kubernetes pod.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Dictionary? Labels { get; set; }
#nullable restore
#else
        public Dictionary Labels { get; set; }
#endif
        /// <summary>The namespace name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>
        /// Instantiates a new kubernetesNamespaceEvidence and sets the default values.
        /// </summary>
        public KubernetesNamespaceEvidence() : base() {
            OdataType = "#microsoft.graph.security.kubernetesNamespaceEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new KubernetesNamespaceEvidence CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KubernetesNamespaceEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"cluster", n => { Cluster = n.GetObjectValue<KubernetesClusterEvidence>(KubernetesClusterEvidence.CreateFromDiscriminatorValue); } },
                {"labels", n => { Labels = n.GetObjectValue<Dictionary>(Dictionary.CreateFromDiscriminatorValue); } },
                {"name", n => { Name = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<KubernetesClusterEvidence>("cluster", Cluster);
            writer.WriteObjectValue<Dictionary>("labels", Labels);
            writer.WriteStringValue("name", Name);
        }
    }
}
