
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacySegmentCircleMenuController+Item
// Generated on: čtvrtek 26. února 2026 12:28:06
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
    public partial class LegacySegmentCircleMenuController
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacySegmentCircleMenuController+Item")]
public partial class Item : global::FrooxEngine.SyncObject

{
    public global::System.Boolean Enabled { get => Enabled_Element.Data; set => Enabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Enabled_Element = new();
public global::System.Single AngleStart { get => AngleStart_Element.Data; set => AngleStart_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AngleStart_Element = new();
public global::System.Single RadiusStart { get => RadiusStart_Element.Data; set => RadiusStart_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RadiusStart_Element = new();
public global::System.Single ArcLength { get => ArcLength_Element.Data; set => ArcLength_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ArcLength_Element = new();
public global::System.Single Thickness { get => Thickness_Element.Data; set => Thickness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Thickness_Element = new();
public global::FrooxEngine.TextRenderer Label { get => Label_Element.Data; set => Label_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.TextRenderer>, global::FrooxEngine.TextRenderer> Label_Element = new();
public UnityEngine.ColorX LabelColor { get => LabelColor_Element.Data; set => LabelColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> LabelColor_Element = new();
public UnityEngine.ColorX OutlineColor { get => OutlineColor_Element.Data; set => OutlineColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> OutlineColor_Element = new();
public UnityEngine.ColorX FillColor { get => FillColor_Element.Data; set => FillColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> FillColor_Element = new();
public global::FrooxEngine.UnlitMaterial IconMaterial { get => IconMaterial_Element.Data; set => IconMaterial_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UnlitMaterial>, global::FrooxEngine.UnlitMaterial> IconMaterial_Element = new();
public global::FrooxEngine.StaticTexture2D IconTexture { get => IconTexture_Element.Data; set => IconTexture_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.StaticTexture2D>, global::FrooxEngine.StaticTexture2D> IconTexture_Element = new();
public global::System.Boolean RotateIcon { get => RotateIcon_Element.Data; set => RotateIcon_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> RotateIcon_Element = new();
public global::FrooxEngine.Slot IconRoot { get => IconRoot_Element.Data; set => IconRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> IconRoot_Element = new();
public global::System.Boolean Highlight { get => Highlight_Element.Data; set => Highlight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Highlight_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> IconPosition { get => IconPosition_Element.Data; set => IconPosition_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> IconPosition_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> IconRotation { get => IconRotation_Element.Data; set => IconRotation_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> IconRotation_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> IconScale { get => IconScale_Element.Data; set => IconScale_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> IconScale_Element = new();
public global::FrooxEngine.Slot ColliderRoot { get => ColliderRoot_Element.Data; set => ColliderRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> ColliderRoot_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> ColliderPosition { get => ColliderPosition_Element.Data; set => ColliderPosition_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> ColliderPosition_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> ColliderScale { get => ColliderScale_Element.Data; set => ColliderScale_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> ColliderScale_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> ColliderRotation { get => ColliderRotation_Element.Data; set => ColliderRotation_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> ColliderRotation_Element = new();
public global::System.Double LastPress { get => LastPress_Element.Data; set => LastPress_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Double>, global::System.Double> LastPress_Element = new();
public global::FrooxEngine.Slot LabelRoot { get => LabelRoot_Element.Data; set => LabelRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> LabelRoot_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> LabelPosition { get => LabelPosition_Element.Data; set => LabelPosition_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> LabelPosition_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> LabelScale { get => LabelScale_Element.Data; set => LabelScale_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> LabelScale_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> LabelColorDrive { get => LabelColorDrive_Element.Data; set => LabelColorDrive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> LabelColorDrive_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Enabled", Enabled_Element.ToLinkField(context));
members.Add("AngleStart", AngleStart_Element.ToLinkField(context));
members.Add("RadiusStart", RadiusStart_Element.ToLinkField(context));
members.Add("ArcLength", ArcLength_Element.ToLinkField(context));
members.Add("Thickness", Thickness_Element.ToLinkField(context));
members.Add("Label", Label_Element.ToLinkReference(context));
members.Add("LabelColor", LabelColor_Element.ToLinkField(context));
members.Add("OutlineColor", OutlineColor_Element.ToLinkField(context));
members.Add("FillColor", FillColor_Element.ToLinkField(context));
members.Add("IconMaterial", IconMaterial_Element.ToLinkReference(context));
members.Add("IconTexture", IconTexture_Element.ToLinkReference(context));
members.Add("RotateIcon", RotateIcon_Element.ToLinkField(context));
members.Add("IconRoot", IconRoot_Element.ToLinkReference(context));
members.Add("Highlight", Highlight_Element.ToLinkField(context));
members.Add("IconPosition", IconPosition_Element.ToLinkReference(context));
members.Add("IconRotation", IconRotation_Element.ToLinkReference(context));
members.Add("IconScale", IconScale_Element.ToLinkReference(context));
members.Add("ColliderRoot", ColliderRoot_Element.ToLinkReference(context));
members.Add("ColliderPosition", ColliderPosition_Element.ToLinkReference(context));
members.Add("ColliderScale", ColliderScale_Element.ToLinkReference(context));
members.Add("ColliderRotation", ColliderRotation_Element.ToLinkReference(context));
members.Add("LastPress", LastPress_Element.ToLinkField(context));
members.Add("LabelRoot", LabelRoot_Element.ToLinkReference(context));
members.Add("LabelPosition", LabelPosition_Element.ToLinkReference(context));
members.Add("LabelScale", LabelScale_Element.ToLinkReference(context));
members.Add("LabelColorDrive", LabelColorDrive_Element.ToLinkReference(context));
}

}
            }
}
