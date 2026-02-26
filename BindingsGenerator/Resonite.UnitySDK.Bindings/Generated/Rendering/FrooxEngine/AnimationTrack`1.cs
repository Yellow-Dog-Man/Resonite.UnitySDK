
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AnimationTrack<>
// Generated on: čtvrtek 26. února 2026 12:28:03
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AnimationTrack<>")]
public partial class AnimationTrack<T> : global::FrooxEngine.Component, global::FrooxEngine.IAnimationTrack
	

{
    public global::System.String _node { get => _node_Element.Data; set => _node_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> _node_Element = new();
public global::System.String _component { get => _component_Element.Data; set => _component_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> _component_Element = new();
public global::System.String _property { get => _property_Element.Data; set => _property_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> _property_Element = new();
public global::SyncArray<global::FrooxEngine.SyncLinear<T>, global::FrooxEngine.LinearKey<T>> Data = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_node", _node_Element.ToLinkField(context));
members.Add("_component", _component_Element.ToLinkField(context));
members.Add("_property", _property_Element.ToLinkField(context));
members.Add("Data", Data.ToLinkArray(context));
}

}
}
