
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioListener
// Generated on: úterý 24. února 2026 18:17:42
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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
    public global::FrooxEngine.User ActiveUser;
public global::FrooxEngine.AudioListener.ListenerTarget TargetOutput;
public System.Collections.Generic.List<global::FrooxEngine.AudioDSP_Effect> Effects;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ActiveUser", ActiveUser.ToResoniteReference(context));
members.Add("TargetOutput", TargetOutput.ToResoniteLinkField());
members.Add("Effects", new ResoniteLink.SyncList()
{
    Elements = Effects.ConvertList(m => m.ToResoniteReference(context))
});
}

}
}
