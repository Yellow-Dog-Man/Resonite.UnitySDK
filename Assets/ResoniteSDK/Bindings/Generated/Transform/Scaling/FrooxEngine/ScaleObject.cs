
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ScaleObject
// Generated on: pátek 13. února 2026 5:52:27
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ScaleObject")]
public partial class ScaleObject : global::FrooxEngine.Component

{
    public global::FrooxEngine.ScaleObjectManager Manager;
public global::System.Single ScalePower;
public UnityEngine.Vector3 ScalePosition;
public global::System.Nullable<UnityEngine.Vector3> OverrideFarTransitionOffset;
public global::System.Boolean CustomTransition;
public global::System.Single TransitionLerp;
public global::FrooxEngine.IField<global::System.Boolean> _active;
public global::FrooxEngine.IField<UnityEngine.Vector3> _position;
public global::FrooxEngine.IField<UnityEngine.Vector3> _scale;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Manager", new ResoniteLink.Reference() { });
members.Add("ScalePower", ScalePower.ToResoniteLinkField());
members.Add("ScalePosition", ScalePosition.ToResoniteLinkField());
members.Add("OverrideFarTransitionOffset", OverrideFarTransitionOffset.ToResoniteLinkField());
members.Add("CustomTransition", CustomTransition.ToResoniteLinkField());
members.Add("TransitionLerp", TransitionLerp.ToResoniteLinkField());
members.Add("_active", new ResoniteLink.Reference() { });
members.Add("_position", new ResoniteLink.Reference() { });
members.Add("_scale", new ResoniteLink.Reference() { });
}

}
}
