// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Profiles.hybrid_2020_09_01.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A common class for general resource information
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VirtualNetworkGatewayConnection : Resource
    {
        /// <summary>
        /// Initializes a new instance of the VirtualNetworkGatewayConnection
        /// class.
        /// </summary>
        public VirtualNetworkGatewayConnection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualNetworkGatewayConnection
        /// class.
        /// </summary>
        /// <param name="virtualNetworkGateway1">The reference to virtual
        /// network gateway resource.</param>
        /// <param name="connectionType">Gateway connection type. Possible
        /// values are: 'Ipsec','Vnet2Vnet','ExpressRoute', and 'VPNClient.
        /// Possible values include: 'IPsec', 'Vnet2Vnet', 'ExpressRoute',
        /// 'VPNClient'</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="authorizationKey">The authorizationKey.</param>
        /// <param name="virtualNetworkGateway2">The reference to virtual
        /// network gateway resource.</param>
        /// <param name="localNetworkGateway2">The reference to local network
        /// gateway resource.</param>
        /// <param name="connectionProtocol">Connection protocol used for this
        /// connection. Possible values include: 'IKEv2', 'IKEv1'</param>
        /// <param name="routingWeight">The routing weight.</param>
        /// <param name="sharedKey">The IPSec shared key.</param>
        /// <param name="connectionStatus">Virtual network Gateway connection
        /// status. Possible values are 'Unknown', 'Connecting', 'Connected'
        /// and 'NotConnected'. Possible values include: 'Unknown',
        /// 'Connecting', 'Connected', 'NotConnected'</param>
        /// <param name="tunnelConnectionStatus">Collection of all tunnels'
        /// connection health status.</param>
        /// <param name="egressBytesTransferred">The egress bytes transferred
        /// in this connection.</param>
        /// <param name="ingressBytesTransferred">The ingress bytes transferred
        /// in this connection.</param>
        /// <param name="peer">The reference to peerings resource.</param>
        /// <param name="enableBgp">EnableBgp flag</param>
        /// <param name="usePolicyBasedTrafficSelectors">Enable policy-based
        /// traffic selectors.</param>
        /// <param name="ipsecPolicies">The IPSec Policies to be considered by
        /// this connection.</param>
        /// <param name="resourceGuid">The resource GUID property of the
        /// VirtualNetworkGatewayConnection resource.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// VirtualNetworkGatewayConnection resource. Possible values are:
        /// 'Updating', 'Deleting', and 'Failed'.</param>
        /// <param name="expressRouteGatewayBypass">Bypass ExpressRoute Gateway
        /// for data forwarding</param>
        /// <param name="etag">Gets a unique read-only string that changes
        /// whenever the resource is updated.</param>
        public VirtualNetworkGatewayConnection(VirtualNetworkGateway virtualNetworkGateway1, string connectionType, string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string authorizationKey = default(string), VirtualNetworkGateway virtualNetworkGateway2 = default(VirtualNetworkGateway), LocalNetworkGateway localNetworkGateway2 = default(LocalNetworkGateway), string connectionProtocol = default(string), int? routingWeight = default(int?), string sharedKey = default(string), string connectionStatus = default(string), IList<TunnelConnectionHealth> tunnelConnectionStatus = default(IList<TunnelConnectionHealth>), long? egressBytesTransferred = default(long?), long? ingressBytesTransferred = default(long?), SubResource peer = default(SubResource), bool? enableBgp = default(bool?), bool? usePolicyBasedTrafficSelectors = default(bool?), IList<IpsecPolicy> ipsecPolicies = default(IList<IpsecPolicy>), string resourceGuid = default(string), string provisioningState = default(string), bool? expressRouteGatewayBypass = default(bool?), string etag = default(string))
            : base(id, name, type, location, tags)
        {
            AuthorizationKey = authorizationKey;
            VirtualNetworkGateway1 = virtualNetworkGateway1;
            VirtualNetworkGateway2 = virtualNetworkGateway2;
            LocalNetworkGateway2 = localNetworkGateway2;
            ConnectionType = connectionType;
            ConnectionProtocol = connectionProtocol;
            RoutingWeight = routingWeight;
            SharedKey = sharedKey;
            ConnectionStatus = connectionStatus;
            TunnelConnectionStatus = tunnelConnectionStatus;
            EgressBytesTransferred = egressBytesTransferred;
            IngressBytesTransferred = ingressBytesTransferred;
            Peer = peer;
            EnableBgp = enableBgp;
            UsePolicyBasedTrafficSelectors = usePolicyBasedTrafficSelectors;
            IpsecPolicies = ipsecPolicies;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
            ExpressRouteGatewayBypass = expressRouteGatewayBypass;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the authorizationKey.
        /// </summary>
        [JsonProperty(PropertyName = "properties.authorizationKey")]
        public string AuthorizationKey { get; set; }

        /// <summary>
        /// Gets or sets the reference to virtual network gateway resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualNetworkGateway1")]
        public VirtualNetworkGateway VirtualNetworkGateway1 { get; set; }

        /// <summary>
        /// Gets or sets the reference to virtual network gateway resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualNetworkGateway2")]
        public VirtualNetworkGateway VirtualNetworkGateway2 { get; set; }

        /// <summary>
        /// Gets or sets the reference to local network gateway resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.localNetworkGateway2")]
        public LocalNetworkGateway LocalNetworkGateway2 { get; set; }

        /// <summary>
        /// Gets or sets gateway connection type. Possible values are:
        /// 'Ipsec','Vnet2Vnet','ExpressRoute', and 'VPNClient. Possible values
        /// include: 'IPsec', 'Vnet2Vnet', 'ExpressRoute', 'VPNClient'
        /// </summary>
        [JsonProperty(PropertyName = "properties.connectionType")]
        public string ConnectionType { get; set; }

        /// <summary>
        /// Gets or sets connection protocol used for this connection. Possible
        /// values include: 'IKEv2', 'IKEv1'
        /// </summary>
        [JsonProperty(PropertyName = "properties.connectionProtocol")]
        public string ConnectionProtocol { get; set; }

        /// <summary>
        /// Gets or sets the routing weight.
        /// </summary>
        [JsonProperty(PropertyName = "properties.routingWeight")]
        public int? RoutingWeight { get; set; }

        /// <summary>
        /// Gets or sets the IPSec shared key.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sharedKey")]
        public string SharedKey { get; set; }

        /// <summary>
        /// Gets virtual network Gateway connection status. Possible values are
        /// 'Unknown', 'Connecting', 'Connected' and 'NotConnected'. Possible
        /// values include: 'Unknown', 'Connecting', 'Connected',
        /// 'NotConnected'
        /// </summary>
        [JsonProperty(PropertyName = "properties.connectionStatus")]
        public string ConnectionStatus { get; private set; }

        /// <summary>
        /// Gets collection of all tunnels' connection health status.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tunnelConnectionStatus")]
        public IList<TunnelConnectionHealth> TunnelConnectionStatus { get; private set; }

        /// <summary>
        /// Gets the egress bytes transferred in this connection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.egressBytesTransferred")]
        public long? EgressBytesTransferred { get; private set; }

        /// <summary>
        /// Gets the ingress bytes transferred in this connection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ingressBytesTransferred")]
        public long? IngressBytesTransferred { get; private set; }

        /// <summary>
        /// Gets or sets the reference to peerings resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.peer")]
        public SubResource Peer { get; set; }

        /// <summary>
        /// Gets or sets enableBgp flag
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableBgp")]
        public bool? EnableBgp { get; set; }

        /// <summary>
        /// Gets or sets enable policy-based traffic selectors.
        /// </summary>
        [JsonProperty(PropertyName = "properties.usePolicyBasedTrafficSelectors")]
        public bool? UsePolicyBasedTrafficSelectors { get; set; }

        /// <summary>
        /// Gets or sets the IPSec Policies to be considered by this
        /// connection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipsecPolicies")]
        public IList<IpsecPolicy> IpsecPolicies { get; set; }

        /// <summary>
        /// Gets or sets the resource GUID property of the
        /// VirtualNetworkGatewayConnection resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceGuid")]
        public string ResourceGuid { get; set; }

        /// <summary>
        /// Gets the provisioning state of the VirtualNetworkGatewayConnection
        /// resource. Possible values are: 'Updating', 'Deleting', and
        /// 'Failed'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets bypass ExpressRoute Gateway for data forwarding
        /// </summary>
        [JsonProperty(PropertyName = "properties.expressRouteGatewayBypass")]
        public bool? ExpressRouteGatewayBypass { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (VirtualNetworkGateway1 == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "VirtualNetworkGateway1");
            }
            if (ConnectionType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ConnectionType");
            }
            if (IpsecPolicies != null)
            {
                foreach (var element in IpsecPolicies)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
