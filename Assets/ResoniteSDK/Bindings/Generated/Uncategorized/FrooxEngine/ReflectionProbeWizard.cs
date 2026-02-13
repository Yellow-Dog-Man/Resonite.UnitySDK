
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ReflectionProbeWizard
// Generated on: pátek 13. února 2026 5:52:36
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ReflectionProbeWizard")]
public partial class ReflectionProbeWizard : global::FrooxEngine.Component, global::FrooxEngine.IDeveloperInterface

{
    public global::FrooxEngine.Slot Root;
public global::System.Boolean ProcessDisabled;
public global::System.Boolean TeleportUserToProbe;
public global::FrooxEngine.UIX.TextField _tag;
public global::FrooxEngine.FloatTextEditorParser _delayBetweenProbes;
public global::System.Int32 _bakeCount;
public global::System.Int32 _bakeIndex;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Root", new ResoniteLink.Reference() { });
members.Add("ProcessDisabled", ProcessDisabled.ToResoniteLinkField());
members.Add("TeleportUserToProbe", TeleportUserToProbe.ToResoniteLinkField());
members.Add("_tag", new ResoniteLink.Reference() { });
members.Add("_delayBetweenProbes", new ResoniteLink.Reference() { });
members.Add("_bakeCount", _bakeCount.ToResoniteLinkField());
members.Add("_bakeIndex", _bakeIndex.ToResoniteLinkField());
}

}
}
