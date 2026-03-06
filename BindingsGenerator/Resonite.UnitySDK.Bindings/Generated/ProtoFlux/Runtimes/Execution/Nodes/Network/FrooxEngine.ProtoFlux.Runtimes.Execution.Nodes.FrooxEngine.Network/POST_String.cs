
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Network.POST_String
// Generated on: pátek 6. března 2026 14:18:50
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Network
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Network.POST_String")]
public partial class POST_String : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Network.StringResponseWebRequest

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> String { get => String_Element.Data; set => String_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>> String_Element = new();
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> MediaType { get => MediaType_Element.Data; set => MediaType_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>> MediaType_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("String", String_Element.ToLinkReference(context));
members.Add("MediaType", MediaType_Element.ToLinkReference(context));
}

}
}
