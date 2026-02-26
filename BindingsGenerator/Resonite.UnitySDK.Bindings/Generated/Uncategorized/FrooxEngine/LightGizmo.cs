
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LightGizmo
// Generated on: čtvrtek 26. února 2026 15:09:13
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LightGizmo")]
public partial class LightGizmo : global::FrooxEngine.Component, global::FrooxEngine.IComponentGizmo

{
    public global::System.Boolean Active { get => Active_Element.Data; set => Active_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Active_Element = new();
public global::FrooxEngine.Light _target { get => _target_Element.Data; set => _target_Element.Data = value; }
public Reference<global::FrooxEngine.RelayRef<global::FrooxEngine.Light>, global::FrooxEngine.Light> _target_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _pointIconActive { get => _pointIconActive_Element.Data; set => _pointIconActive_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _pointIconActive_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _spotIconActive { get => _spotIconActive_Element.Data; set => _spotIconActive_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _spotIconActive_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _directionalIconActive { get => _directionalIconActive_Element.Data; set => _directionalIconActive_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _directionalIconActive_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _pointActive { get => _pointActive_Element.Data; set => _pointActive_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _pointActive_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _spotActive { get => _spotActive_Element.Data; set => _spotActive_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _spotActive_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _directionalActive { get => _directionalActive_Element.Data; set => _directionalActive_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _directionalActive_Element = new();
public global::FrooxEngine.SphereGizmo _pointGizmo { get => _pointGizmo_Element.Data; set => _pointGizmo_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.SphereGizmo>, global::FrooxEngine.SphereGizmo> _pointGizmo_Element = new();
public global::FrooxEngine.ConeGizmo _spotGizmo { get => _spotGizmo_Element.Data; set => _spotGizmo_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ConeGizmo>, global::FrooxEngine.ConeGizmo> _spotGizmo_Element = new();
public global::FrooxEngine.VectorGizmo _dirGizmo { get => _dirGizmo_Element.Data; set => _dirGizmo_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.VectorGizmo>, global::FrooxEngine.VectorGizmo> _dirGizmo_Element = new();
public global::FrooxEngine.OverlayFresnelMaterial _iconMaterial { get => _iconMaterial_Element.Data; set => _iconMaterial_Element.Data = value; }
public Reference<global::FrooxEngine.DriveRef<global::FrooxEngine.OverlayFresnelMaterial>, global::FrooxEngine.OverlayFresnelMaterial> _iconMaterial_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Active", Active_Element.ToLinkField(context));
members.Add("_target", _target_Element.ToLinkReference(context));
members.Add("_pointIconActive", _pointIconActive_Element.ToLinkReference(context));
members.Add("_spotIconActive", _spotIconActive_Element.ToLinkReference(context));
members.Add("_directionalIconActive", _directionalIconActive_Element.ToLinkReference(context));
members.Add("_pointActive", _pointActive_Element.ToLinkReference(context));
members.Add("_spotActive", _spotActive_Element.ToLinkReference(context));
members.Add("_directionalActive", _directionalActive_Element.ToLinkReference(context));
members.Add("_pointGizmo", _pointGizmo_Element.ToLinkReference(context));
members.Add("_spotGizmo", _spotGizmo_Element.ToLinkReference(context));
members.Add("_dirGizmo", _dirGizmo_Element.ToLinkReference(context));
members.Add("_iconMaterial", _iconMaterial_Element.ToLinkReference(context));
}

}
}
