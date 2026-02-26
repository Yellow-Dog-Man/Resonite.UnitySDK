
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.HoverPlayback
// Generated on: čtvrtek 26. února 2026 15:08:01
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.HoverPlayback")]
public partial class HoverPlayback : global::FrooxEngine.Component, global::FrooxEngine.ITouchable

{
    public global::FrooxEngine.SyncPlayback Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.SyncPlayback>, global::FrooxEngine.SyncPlayback> Target_Element = new();
public global::FrooxEngine.HoverPlayback.PlayTrigger Trigger { get => Trigger_Element.Data; set => Trigger_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.HoverPlayback.PlayTrigger>, global::FrooxEngine.HoverPlayback.PlayTrigger> Trigger_Element = new();
public global::System.Boolean FromBeginning { get => FromBeginning_Element.Data; set => FromBeginning_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> FromBeginning_Element = new();
public global::System.Boolean Loop { get => Loop_Element.Data; set => Loop_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Loop_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target_Element.ToLinkReference(context));
members.Add("Trigger", Trigger_Element.ToLinkField(context));
members.Add("FromBeginning", FromBeginning_Element.ToLinkField(context));
members.Add("Loop", Loop_Element.ToLinkField(context));
}

}
}
