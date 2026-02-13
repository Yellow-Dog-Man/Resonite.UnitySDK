
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LightGizmo
// Generated on: pátek 13. února 2026 23:23:16
// Resonite version: 2026.2.12.359
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Active", Active.ToResoniteLinkField());
members.Add("_target", new ResoniteLink.Reference() { });
members.Add("_pointIconActive", new ResoniteLink.Reference() { });
members.Add("_spotIconActive", new ResoniteLink.Reference() { });
members.Add("_directionalIconActive", new ResoniteLink.Reference() { });
members.Add("_pointActive", new ResoniteLink.Reference() { });
members.Add("_spotActive", new ResoniteLink.Reference() { });
members.Add("_directionalActive", new ResoniteLink.Reference() { });
members.Add("_pointGizmo", new ResoniteLink.Reference() { });
members.Add("_spotGizmo", new ResoniteLink.Reference() { });
members.Add("_dirGizmo", new ResoniteLink.Reference() { });
members.Add("_iconMaterial", new ResoniteLink.Reference() { });
}

}
}
