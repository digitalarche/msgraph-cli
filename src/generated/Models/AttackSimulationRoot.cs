// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class AttackSimulationRoot : Entity, IParsable {
        /// <summary>Represents an end user&apos;s notification for an attack simulation training.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EndUserNotification>? EndUserNotifications { get; set; }
#nullable restore
#else
        public List<EndUserNotification> EndUserNotifications { get; set; }
#endif
        /// <summary>Represents an attack simulation training landing page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<LandingPage>? LandingPages { get; set; }
#nullable restore
#else
        public List<LandingPage> LandingPages { get; set; }
#endif
        /// <summary>Represents an attack simulation training login page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<LoginPage>? LoginPages { get; set; }
#nullable restore
#else
        public List<LoginPage> LoginPages { get; set; }
#endif
        /// <summary>Represents an attack simulation training operation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AttackSimulationOperation>? Operations { get; set; }
#nullable restore
#else
        public List<AttackSimulationOperation> Operations { get; set; }
#endif
        /// <summary>Represents an attack simulation training campaign payload in a tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Payload>? Payloads { get; set; }
#nullable restore
#else
        public List<Payload> Payloads { get; set; }
#endif
        /// <summary>Represents simulation automation created to run on a tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SimulationAutomation>? SimulationAutomations { get; set; }
#nullable restore
#else
        public List<SimulationAutomation> SimulationAutomations { get; set; }
#endif
        /// <summary>Represents an attack simulation training campaign in a tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Simulation>? Simulations { get; set; }
#nullable restore
#else
        public List<Simulation> Simulations { get; set; }
#endif
        /// <summary>Represents details about attack simulation trainings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Training>? Trainings { get; set; }
#nullable restore
#else
        public List<Training> Trainings { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AttackSimulationRoot CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AttackSimulationRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"endUserNotifications", n => { EndUserNotifications = n.GetCollectionOfObjectValues<EndUserNotification>(EndUserNotification.CreateFromDiscriminatorValue)?.ToList(); } },
                {"landingPages", n => { LandingPages = n.GetCollectionOfObjectValues<LandingPage>(LandingPage.CreateFromDiscriminatorValue)?.ToList(); } },
                {"loginPages", n => { LoginPages = n.GetCollectionOfObjectValues<LoginPage>(LoginPage.CreateFromDiscriminatorValue)?.ToList(); } },
                {"operations", n => { Operations = n.GetCollectionOfObjectValues<AttackSimulationOperation>(AttackSimulationOperation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"payloads", n => { Payloads = n.GetCollectionOfObjectValues<Payload>(Payload.CreateFromDiscriminatorValue)?.ToList(); } },
                {"simulationAutomations", n => { SimulationAutomations = n.GetCollectionOfObjectValues<SimulationAutomation>(SimulationAutomation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"simulations", n => { Simulations = n.GetCollectionOfObjectValues<Simulation>(Simulation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"trainings", n => { Trainings = n.GetCollectionOfObjectValues<Training>(Training.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<EndUserNotification>("endUserNotifications", EndUserNotifications);
            writer.WriteCollectionOfObjectValues<LandingPage>("landingPages", LandingPages);
            writer.WriteCollectionOfObjectValues<LoginPage>("loginPages", LoginPages);
            writer.WriteCollectionOfObjectValues<AttackSimulationOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<Payload>("payloads", Payloads);
            writer.WriteCollectionOfObjectValues<SimulationAutomation>("simulationAutomations", SimulationAutomations);
            writer.WriteCollectionOfObjectValues<Simulation>("simulations", Simulations);
            writer.WriteCollectionOfObjectValues<Training>("trainings", Trainings);
        }
    }
}
