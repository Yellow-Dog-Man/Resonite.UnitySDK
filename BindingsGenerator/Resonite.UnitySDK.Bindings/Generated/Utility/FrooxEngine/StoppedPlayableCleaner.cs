
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.StoppedPlayableCleaner
// Generated on: čtvrtek 26. února 2026 10:04:50
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.StoppedPlayableCleaner")]
public partial class StoppedPlayableCleaner : global::FrooxEngine.Component

{
    public global::FrooxEngine.IPlayable Playable { get => Playable_Element.Data; set => Playable_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IPlayable>, global::FrooxEngine.IPlayable> Playable_Element = new();
public global::System.Single GracePeriod { get => GracePeriod_Element.Data; set => GracePeriod_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> GracePeriod_Element = new();
public global::FrooxEngine.User CheckingUser { get => CheckingUser_Element.Data; set => CheckingUser_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.User>, global::FrooxEngine.User> CheckingUser_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Playable", Playable_Element.Data.ToResoniteReference(context));
members.Add("GracePeriod", GracePeriod_Element.Data.ToResoniteLinkField());
members.Add("CheckingUser", CheckingUser_Element.Data.ToResoniteReference(context));
}

}
}
