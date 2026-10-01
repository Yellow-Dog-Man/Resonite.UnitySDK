
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RigBoneProxy
// Generated on: pátek 14. srpna 2026 21:57:42
// Resonite version: 2026.8.12.1196
// Resonite Link Version: 0.13.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RigBoneProxy")]
public partial class RigBoneProxy : global::FrooxEngine.Component

{
    public global::FrooxEngine.Rig Rig { get => Rig_Element.Data; set => Rig_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Rig>, global::FrooxEngine.Rig> Rig_Element = new();
public global::FrooxEngine.Slot ParentBone { get => ParentBone_Element.Data; set => ParentBone_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> ParentBone_Element = new();
public global::FrooxEngine.OverlayFresnelMaterial _material { get => _material_Element.Data; set => _material_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.OverlayFresnelMaterial>, global::FrooxEngine.OverlayFresnelMaterial> _material_Element = new();
public global::FrooxEngine.Slot _selfVisualRoot { get => _selfVisualRoot_Element.Data; set => _selfVisualRoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _selfVisualRoot_Element = new();
public global::FrooxEngine.Slot _linkVisualRoot { get => _linkVisualRoot_Element.Data; set => _linkVisualRoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _linkVisualRoot_Element = new();
public global::FrooxEngine.IField<global::System.Single> _selfRadius { get => _selfRadius_Element.Data; set => _selfRadius_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _selfRadius_Element = new();
public global::FrooxEngine.IField<global::System.Single> _linkWidth { get => _linkWidth_Element.Data; set => _linkWidth_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _linkWidth_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _linkVisualActive { get => _linkVisualActive_Element.Data; set => _linkVisualActive_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _linkVisualActive_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _linkVisualPos { get => _linkVisualPos_Element.Data; set => _linkVisualPos_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _linkVisualPos_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _linkVisualRot { get => _linkVisualRot_Element.Data; set => _linkVisualRot_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _linkVisualRot_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _linkVisualScale { get => _linkVisualScale_Element.Data; set => _linkVisualScale_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _linkVisualScale_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Rig", Rig_Element.ToLinkReference(context));
members.Add("ParentBone", ParentBone_Element.ToLinkReference(context));
members.Add("_material", _material_Element.ToLinkReference(context));
members.Add("_selfVisualRoot", _selfVisualRoot_Element.ToLinkReference(context));
members.Add("_linkVisualRoot", _linkVisualRoot_Element.ToLinkReference(context));
members.Add("_selfRadius", _selfRadius_Element.ToLinkReference(context));
members.Add("_linkWidth", _linkWidth_Element.ToLinkReference(context));
members.Add("_linkVisualActive", _linkVisualActive_Element.ToLinkReference(context));
members.Add("_linkVisualPos", _linkVisualPos_Element.ToLinkReference(context));
members.Add("_linkVisualRot", _linkVisualRot_Element.ToLinkReference(context));
members.Add("_linkVisualScale", _linkVisualScale_Element.ToLinkReference(context));
}

}
}
