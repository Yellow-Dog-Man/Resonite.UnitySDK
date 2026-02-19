
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ScaleObject
// Generated on: čtvrtek 19. února 2026 8:00:24
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Manager", Manager.ToResoniteReference(context));
members.Add("ScalePower", ScalePower.ToResoniteLinkField());
members.Add("ScalePosition", ScalePosition.ToResoniteLinkField());
members.Add("OverrideFarTransitionOffset", OverrideFarTransitionOffset.ToResoniteLinkField());
members.Add("CustomTransition", CustomTransition.ToResoniteLinkField());
members.Add("TransitionLerp", TransitionLerp.ToResoniteLinkField());
members.Add("_active", _active.ToResoniteReference(context));
members.Add("_position", _position.ToResoniteReference(context));
members.Add("_scale", _scale.ToResoniteReference(context));
}

}
}
