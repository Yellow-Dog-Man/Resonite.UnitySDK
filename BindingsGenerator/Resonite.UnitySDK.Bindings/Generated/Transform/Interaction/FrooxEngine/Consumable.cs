
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Consumable
// Generated on: pátek 14. srpna 2026 21:56:19
// Resonite version: 2026.8.12.1196
// Resonite Link Version: 0.13.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Consumable")]
public partial class Consumable : global::FrooxEngine.Component, global::FrooxEngine.ICustomInspector

{
    public global::System.Boolean MustBeHolding { get => MustBeHolding_Element.Data; set => MustBeHolding_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> MustBeHolding_Element = new();
public global::System.Boolean CanFeedToOthers { get => CanFeedToOthers_Element.Data; set => CanFeedToOthers_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> CanFeedToOthers_Element = new();
public global::FrooxEngine.Slot OverrideReferencePoint { get => OverrideReferencePoint_Element.Data; set => OverrideReferencePoint_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> OverrideReferencePoint_Element = new();
public global::System.Single Radius { get => Radius_Element.Data; set => Radius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Radius_Element = new();
public global::System.Single StartHysteresis { get => StartHysteresis_Element.Data; set => StartHysteresis_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> StartHysteresis_Element = new();
public global::System.Int32 CurrentStageIndex { get => CurrentStageIndex_Element.Data; set => CurrentStageIndex_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> CurrentStageIndex_Element = new();
public global::System.Boolean IsBeingConsumed { get => IsBeingConsumed_Element.Data; set => IsBeingConsumed_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> IsBeingConsumed_Element = new();
public global::System.Boolean HasBeenFullyConsumed { get => HasBeenFullyConsumed_Element.Data; set => HasBeenFullyConsumed_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> HasBeenFullyConsumed_Element = new();
public global::FrooxEngine.UserRef CurrentlyConsumingUser = new();
public global::System.Boolean DestroyOnConsumed { get => DestroyOnConsumed_Element.Data; set => DestroyOnConsumed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DestroyOnConsumed_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.Consumable.Stage>, global::FrooxEngine.Consumable.Stage> Stages = new();
public global::System.Boolean _waitingForReset { get => _waitingForReset_Element.Data; set => _waitingForReset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _waitingForReset_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MustBeHolding", MustBeHolding_Element.ToLinkField(context));
members.Add("CanFeedToOthers", CanFeedToOthers_Element.ToLinkField(context));
members.Add("OverrideReferencePoint", OverrideReferencePoint_Element.ToLinkReference(context));
members.Add("Radius", Radius_Element.ToLinkField(context));
members.Add("StartHysteresis", StartHysteresis_Element.ToLinkField(context));
members.Add("CurrentStageIndex", CurrentStageIndex_Element.ToLinkField(context));
members.Add("IsBeingConsumed", IsBeingConsumed_Element.ToLinkField(context));
members.Add("HasBeenFullyConsumed", HasBeenFullyConsumed_Element.ToLinkField(context));
members.Add("CurrentlyConsumingUser", CurrentlyConsumingUser.ToLinkSyncObject(context));
members.Add("DestroyOnConsumed", DestroyOnConsumed_Element.ToLinkField(context));
members.Add("Stages", Stages.ToLinkList(context, m => m.ToLinkSyncObject(context)));
members.Add("_waitingForReset", _waitingForReset_Element.ToLinkField(context));
}

}
}
