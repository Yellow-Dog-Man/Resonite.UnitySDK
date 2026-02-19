
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LightGizmo
// Generated on: čtvrtek 19. února 2026 8:00:29
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LightGizmo")]
public partial class LightGizmo : global::FrooxEngine.Component, global::FrooxEngine.IComponentGizmo

{
    public global::System.Boolean Active;
public global::FrooxEngine.Light _target;
public global::FrooxEngine.IField<global::System.Boolean> _pointIconActive;
public global::FrooxEngine.IField<global::System.Boolean> _spotIconActive;
public global::FrooxEngine.IField<global::System.Boolean> _directionalIconActive;
public global::FrooxEngine.IField<global::System.Boolean> _pointActive;
public global::FrooxEngine.IField<global::System.Boolean> _spotActive;
public global::FrooxEngine.IField<global::System.Boolean> _directionalActive;
public global::FrooxEngine.SphereGizmo _pointGizmo;
public global::FrooxEngine.ConeGizmo _spotGizmo;
public global::FrooxEngine.VectorGizmo _dirGizmo;
public global::FrooxEngine.OverlayFresnelMaterial _iconMaterial;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Active", Active.ToResoniteLinkField());
members.Add("_target", _target.ToResoniteReference(context));
members.Add("_pointIconActive", _pointIconActive.ToResoniteReference(context));
members.Add("_spotIconActive", _spotIconActive.ToResoniteReference(context));
members.Add("_directionalIconActive", _directionalIconActive.ToResoniteReference(context));
members.Add("_pointActive", _pointActive.ToResoniteReference(context));
members.Add("_spotActive", _spotActive.ToResoniteReference(context));
members.Add("_directionalActive", _directionalActive.ToResoniteReference(context));
members.Add("_pointGizmo", _pointGizmo.ToResoniteReference(context));
members.Add("_spotGizmo", _spotGizmo.ToResoniteReference(context));
members.Add("_dirGizmo", _dirGizmo.ToResoniteReference(context));
members.Add("_iconMaterial", _iconMaterial.ToResoniteReference(context));
}

}
}
