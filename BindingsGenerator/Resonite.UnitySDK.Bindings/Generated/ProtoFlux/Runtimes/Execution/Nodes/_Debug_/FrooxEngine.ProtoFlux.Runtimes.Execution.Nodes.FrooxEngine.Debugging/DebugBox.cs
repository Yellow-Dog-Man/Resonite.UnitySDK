
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Debugging.DebugBox
// Generated on: pátek 6. března 2026 14:18:41
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Debugging
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Debugging.DebugBox")]
public partial class DebugBox : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Debugging.DebugNode

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> Point { get => Point_Element.Data; set => Point_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3>> Point_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3> Size { get => Size_Element.Data; set => Size_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Vector3>> Size_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Quaternion> Orientation { get => Orientation_Element.Data; set => Orientation_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Quaternion>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.Quaternion>> Orientation_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.ColorX> Color { get => Color_Element.Data; set => Color_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.ColorX>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<UnityEngine.ColorX>> Color_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Duration { get => Duration_Element.Data; set => Duration_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>> Duration_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Point", Point_Element.ToLinkReference(context));
members.Add("Size", Size_Element.ToLinkReference(context));
members.Add("Orientation", Orientation_Element.ToLinkReference(context));
members.Add("Color", Color_Element.ToLinkReference(context));
members.Add("Duration", Duration_Element.ToLinkReference(context));
}

}
}
