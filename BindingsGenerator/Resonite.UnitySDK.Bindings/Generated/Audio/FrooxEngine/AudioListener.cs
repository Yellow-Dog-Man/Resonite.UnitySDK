
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioListener
// Generated on: čtvrtek 26. února 2026 15:07:56
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioListener")]
public partial class AudioListener : global::FrooxEngine.Component, global::FrooxEngine.IWorldAudioDataSource

{
    public global::FrooxEngine.User ActiveUser { get => ActiveUser_Element.Data; set => ActiveUser_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.User>, global::FrooxEngine.User> ActiveUser_Element = new();
public global::FrooxEngine.AudioListener.ListenerTarget TargetOutput { get => TargetOutput_Element.Data; set => TargetOutput_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.AudioListener.ListenerTarget>, global::FrooxEngine.AudioListener.ListenerTarget> TargetOutput_Element = new();
public global::SyncFieldList<global::FrooxEngine.AutoSyncRefList<global::FrooxEngine.AudioDSP_Effect>, global::FrooxEngine.AudioDSP_Effect, Reference<global::FrooxEngine.AutoSyncRef<global::FrooxEngine.AudioDSP_Effect>, global::FrooxEngine.AudioDSP_Effect>> Effects = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ActiveUser", ActiveUser_Element.ToLinkReference(context));
members.Add("TargetOutput", TargetOutput_Element.ToLinkField(context));
members.Add("Effects", Effects.ToLinkList(context, m => m.ToLinkReference(context)));
}

}
}
