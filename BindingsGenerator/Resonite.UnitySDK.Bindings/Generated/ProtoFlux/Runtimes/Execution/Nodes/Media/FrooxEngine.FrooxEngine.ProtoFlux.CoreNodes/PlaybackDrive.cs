
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.PlaybackDrive
// Generated on: čtvrtek 26. února 2026 10:04:21
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.FrooxEngine.ProtoFlux.CoreNodes.PlaybackDrive")]
public partial class PlaybackDrive : global::FrooxEngine.FrooxEngine.ProtoFlux.ProxyVoidNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext,global::FrooxEngine.ProtoFlux.CoreNodes.PlaybackDrive.Proxy>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.SyncPlayback> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.SyncPlayback>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.SyncPlayback>> Target_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> NormalizedPosition { get => NormalizedPosition_Element.Data; set => NormalizedPosition_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>> NormalizedPosition_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> MaximumPositionError { get => MaximumPositionError_Element.Data; set => MaximumPositionError_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>> MaximumPositionError_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Speed { get => Speed_Element.Data; set => Speed_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single>> Speed_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> Play { get => Play_Element.Data; set => Play_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> Play_Element = new();
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> Loop { get => Loop_Element.Data; set => Loop_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> Loop_Element = new();
public global::FrooxEngine.ProtoFlux.NodeValueOutput<global::System.Boolean> IsDriving = new();
public global::FrooxEngine.ProtoFlux.SyncNodeOperation StartDrive = new();
public global::FrooxEngine.ProtoFlux.SyncNodeOperation StopDrive = new();
public global::FrooxEngine.ProtoFlux.SyncNodeOperation ForceResync = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnStartDrive { get => OnStartDrive_Element.Data; set => OnStartDrive_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnStartDrive_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnStopDrive { get => OnStopDrive_Element.Data; set => OnStopDrive_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnStopDrive_Element = new();
public global::FrooxEngine.ProtoFlux.INodeOperation OnResync { get => OnResync_Element.Data; set => OnResync_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeOperation>, global::FrooxEngine.ProtoFlux.INodeOperation> OnResync_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target_Element.Data.ToResoniteReference(context));
members.Add("NormalizedPosition", NormalizedPosition_Element.Data.ToResoniteReference(context));
members.Add("MaximumPositionError", MaximumPositionError_Element.Data.ToResoniteReference(context));
members.Add("Speed", Speed_Element.Data.ToResoniteReference(context));
members.Add("Play", Play_Element.Data.ToResoniteReference(context));
members.Add("Loop", Loop_Element.Data.ToResoniteReference(context));
members.Add("IsDriving", new ResoniteLink.EmptyElement());
members.Add("StartDrive", new ResoniteLink.EmptyElement());
members.Add("StopDrive", new ResoniteLink.EmptyElement());
members.Add("ForceResync", new ResoniteLink.EmptyElement());
members.Add("OnStartDrive", OnStartDrive_Element.Data.ToResoniteReference(context));
members.Add("OnStopDrive", OnStopDrive_Element.Data.ToResoniteReference(context));
members.Add("OnResync", OnResync_Element.Data.ToResoniteReference(context));
}

}
}
