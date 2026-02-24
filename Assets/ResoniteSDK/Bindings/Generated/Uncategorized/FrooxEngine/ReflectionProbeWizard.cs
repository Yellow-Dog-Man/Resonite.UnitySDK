
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ReflectionProbeWizard
// Generated on: úterý 24. února 2026 18:20:27
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Root", Root.ToResoniteReference(context));
members.Add("ProcessDisabled", ProcessDisabled.ToResoniteLinkField());
members.Add("TeleportUserToProbe", TeleportUserToProbe.ToResoniteLinkField());
members.Add("_tag", _tag.ToResoniteReference(context));
members.Add("_delayBetweenProbes", _delayBetweenProbes.ToResoniteReference(context));
members.Add("_bakeCount", _bakeCount.ToResoniteLinkField());
members.Add("_bakeIndex", _bakeIndex.ToResoniteLinkField());
}

}
}
