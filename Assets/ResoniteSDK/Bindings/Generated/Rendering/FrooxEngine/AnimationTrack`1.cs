
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AnimationTrack<>
// Generated on: úterý 24. února 2026 18:20:06
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AnimationTrack<>")]
public partial class AnimationTrack<T> : global::FrooxEngine.Component, global::FrooxEngine.IAnimationTrack
	

{
    public global::System.String _node;
public global::System.String _component;
public global::System.String _property;
public global::FrooxEngine.LinearKey<T>[] Data;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_node", _node.ToResoniteLinkField());
members.Add("_component", _component.ToResoniteLinkField());
members.Add("_property", _property.ToResoniteLinkField());
members.Add("Data", Data.ToResoniteLinkArray());
}

}
}
