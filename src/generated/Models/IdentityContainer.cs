// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models
{
    #pragma warning disable CS1591
    public class IdentityContainer : Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Represents entry point for API connectors.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IdentityApiConnector>? ApiConnectors { get; set; }
#nullable restore
#else
        public List<IdentityApiConnector> ApiConnectors { get; set; }
#endif
        /// <summary>Represents listeners for custom authentication extension events in Azure AD for workforce and customers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AuthenticationEventListener>? AuthenticationEventListeners { get; set; }
#nullable restore
#else
        public List<AuthenticationEventListener> AuthenticationEventListeners { get; set; }
#endif
        /// <summary>Represents the entry point for self-service sign-up and sign-in user flows in both Microsoft Entra workforce and external tenants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AuthenticationEventsFlow>? AuthenticationEventsFlows { get; set; }
#nullable restore
#else
        public List<AuthenticationEventsFlow> AuthenticationEventsFlows { get; set; }
#endif
        /// <summary>Represents entry point for B2X/self-service sign-up identity userflows.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<B2xIdentityUserFlow>? B2xUserFlows { get; set; }
#nullable restore
#else
        public List<B2xIdentityUserFlow> B2xUserFlows { get; set; }
#endif
        /// <summary>the entry point for the Conditional Access (CA) object model.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ConditionalAccessRoot? ConditionalAccess { get; set; }
#nullable restore
#else
        public ConditionalAccessRoot ConditionalAccess { get; set; }
#endif
        /// <summary>Represents custom extensions to authentication flows in Azure AD for workforce and customers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CustomAuthenticationExtension>? CustomAuthenticationExtensions { get; set; }
#nullable restore
#else
        public List<CustomAuthenticationExtension> CustomAuthenticationExtensions { get; set; }
#endif
        /// <summary>The identityProviders property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IdentityProviderBase>? IdentityProviders { get; set; }
#nullable restore
#else
        public List<IdentityProviderBase> IdentityProviders { get; set; }
#endif
        /// <summary>Represents entry point for identity userflow attributes.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IdentityUserFlowAttribute>? UserFlowAttributes { get; set; }
#nullable restore
#else
        public List<IdentityUserFlowAttribute> UserFlowAttributes { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="IdentityContainer"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new IdentityContainer CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IdentityContainer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "apiConnectors", n => { ApiConnectors = n.GetCollectionOfObjectValues<IdentityApiConnector>(IdentityApiConnector.CreateFromDiscriminatorValue)?.ToList(); } },
                { "authenticationEventListeners", n => { AuthenticationEventListeners = n.GetCollectionOfObjectValues<AuthenticationEventListener>(AuthenticationEventListener.CreateFromDiscriminatorValue)?.ToList(); } },
                { "authenticationEventsFlows", n => { AuthenticationEventsFlows = n.GetCollectionOfObjectValues<AuthenticationEventsFlow>(AuthenticationEventsFlow.CreateFromDiscriminatorValue)?.ToList(); } },
                { "b2xUserFlows", n => { B2xUserFlows = n.GetCollectionOfObjectValues<B2xIdentityUserFlow>(B2xIdentityUserFlow.CreateFromDiscriminatorValue)?.ToList(); } },
                { "conditionalAccess", n => { ConditionalAccess = n.GetObjectValue<ConditionalAccessRoot>(ConditionalAccessRoot.CreateFromDiscriminatorValue); } },
                { "customAuthenticationExtensions", n => { CustomAuthenticationExtensions = n.GetCollectionOfObjectValues<CustomAuthenticationExtension>(CustomAuthenticationExtension.CreateFromDiscriminatorValue)?.ToList(); } },
                { "identityProviders", n => { IdentityProviders = n.GetCollectionOfObjectValues<IdentityProviderBase>(IdentityProviderBase.CreateFromDiscriminatorValue)?.ToList(); } },
                { "userFlowAttributes", n => { UserFlowAttributes = n.GetCollectionOfObjectValues<IdentityUserFlowAttribute>(IdentityUserFlowAttribute.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<IdentityApiConnector>("apiConnectors", ApiConnectors);
            writer.WriteCollectionOfObjectValues<AuthenticationEventListener>("authenticationEventListeners", AuthenticationEventListeners);
            writer.WriteCollectionOfObjectValues<AuthenticationEventsFlow>("authenticationEventsFlows", AuthenticationEventsFlows);
            writer.WriteCollectionOfObjectValues<B2xIdentityUserFlow>("b2xUserFlows", B2xUserFlows);
            writer.WriteObjectValue<ConditionalAccessRoot>("conditionalAccess", ConditionalAccess);
            writer.WriteCollectionOfObjectValues<CustomAuthenticationExtension>("customAuthenticationExtensions", CustomAuthenticationExtensions);
            writer.WriteCollectionOfObjectValues<IdentityProviderBase>("identityProviders", IdentityProviders);
            writer.WriteCollectionOfObjectValues<IdentityUserFlowAttribute>("userFlowAttributes", UserFlowAttributes);
        }
    }
}
