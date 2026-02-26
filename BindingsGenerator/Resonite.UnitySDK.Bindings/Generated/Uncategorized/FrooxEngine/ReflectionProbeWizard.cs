
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ReflectionProbeWizard
// Generated on: čtvrtek 26. února 2026 15:09:14
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ReflectionProbeWizard")]
public partial class ReflectionProbeWizard : global::FrooxEngine.Component, global::FrooxEngine.IDeveloperInterface

{
    public global::FrooxEngine.Slot Root { get => Root_Element.Data; set => Root_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> Root_Element = new();
public global::System.Boolean ProcessDisabled { get => ProcessDisabled_Element.Data; set => ProcessDisabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ProcessDisabled_Element = new();
public global::System.Boolean TeleportUserToProbe { get => TeleportUserToProbe_Element.Data; set => TeleportUserToProbe_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> TeleportUserToProbe_Element = new();
public global::FrooxEngine.UIX.TextField _tag { get => _tag_Element.Data; set => _tag_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.TextField>, global::FrooxEngine.UIX.TextField> _tag_Element = new();
public global::FrooxEngine.FloatTextEditorParser _delayBetweenProbes { get => _delayBetweenProbes_Element.Data; set => _delayBetweenProbes_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.FloatTextEditorParser>, global::FrooxEngine.FloatTextEditorParser> _delayBetweenProbes_Element = new();
public global::System.Int32 _bakeCount { get => _bakeCount_Element.Data; set => _bakeCount_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> _bakeCount_Element = new();
public global::System.Int32 _bakeIndex { get => _bakeIndex_Element.Data; set => _bakeIndex_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> _bakeIndex_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Root", Root_Element.ToLinkReference(context));
members.Add("ProcessDisabled", ProcessDisabled_Element.ToLinkField(context));
members.Add("TeleportUserToProbe", TeleportUserToProbe_Element.ToLinkField(context));
members.Add("_tag", _tag_Element.ToLinkReference(context));
members.Add("_delayBetweenProbes", _delayBetweenProbes_Element.ToLinkReference(context));
members.Add("_bakeCount", _bakeCount_Element.ToLinkField(context));
members.Add("_bakeIndex", _bakeIndex_Element.ToLinkField(context));
}

}
}
