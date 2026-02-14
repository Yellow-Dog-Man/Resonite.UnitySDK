
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacySegmentCircleMenuController+Item
// Generated on: sobota 14. února 2026 8:58:37
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
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
    public global::System.Boolean Enabled;
public global::System.Single AngleStart;
public global::System.Single RadiusStart;
public global::System.Single ArcLength;
public global::System.Single Thickness;
public global::FrooxEngine.TextRenderer Label;
public UnityEngine.ColorX LabelColor;
public UnityEngine.ColorX OutlineColor;
public UnityEngine.ColorX FillColor;
public global::FrooxEngine.UnlitMaterial IconMaterial;
public global::FrooxEngine.StaticTexture2D IconTexture;
public global::System.Boolean RotateIcon;
public global::FrooxEngine.Slot IconRoot;
public global::System.Boolean Highlight;
public global::FrooxEngine.IField<UnityEngine.Vector3> IconPosition;
public global::FrooxEngine.IField<UnityEngine.Quaternion> IconRotation;
public global::FrooxEngine.IField<UnityEngine.Vector3> IconScale;
public global::FrooxEngine.Slot ColliderRoot;
public global::FrooxEngine.IField<UnityEngine.Vector3> ColliderPosition;
public global::FrooxEngine.IField<UnityEngine.Vector3> ColliderScale;
public global::FrooxEngine.IField<UnityEngine.Quaternion> ColliderRotation;
public global::System.Double LastPress;
public global::FrooxEngine.Slot LabelRoot;
public global::FrooxEngine.IField<UnityEngine.Vector3> LabelPosition;
public global::FrooxEngine.IField<UnityEngine.Vector3> LabelScale;
public global::FrooxEngine.IField<UnityEngine.ColorX> LabelColorDrive;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Enabled", Enabled.ToResoniteLinkField());
members.Add("AngleStart", AngleStart.ToResoniteLinkField());
members.Add("RadiusStart", RadiusStart.ToResoniteLinkField());
members.Add("ArcLength", ArcLength.ToResoniteLinkField());
members.Add("Thickness", Thickness.ToResoniteLinkField());
members.Add("Label", Label.ToResoniteReference(context));
members.Add("LabelColor", LabelColor.ToResoniteLinkField());
members.Add("OutlineColor", OutlineColor.ToResoniteLinkField());
members.Add("FillColor", FillColor.ToResoniteLinkField());
members.Add("IconMaterial", IconMaterial.ToResoniteReference(context));
members.Add("IconTexture", IconTexture.ToResoniteReference(context));
members.Add("RotateIcon", RotateIcon.ToResoniteLinkField());
members.Add("IconRoot", IconRoot.ToResoniteReference(context));
members.Add("Highlight", Highlight.ToResoniteLinkField());
members.Add("IconPosition", IconPosition.ToResoniteReference(context));
members.Add("IconRotation", IconRotation.ToResoniteReference(context));
members.Add("IconScale", IconScale.ToResoniteReference(context));
members.Add("ColliderRoot", ColliderRoot.ToResoniteReference(context));
members.Add("ColliderPosition", ColliderPosition.ToResoniteReference(context));
members.Add("ColliderScale", ColliderScale.ToResoniteReference(context));
members.Add("ColliderRotation", ColliderRotation.ToResoniteReference(context));
members.Add("LastPress", LastPress.ToResoniteLinkField());
members.Add("LabelRoot", LabelRoot.ToResoniteReference(context));
members.Add("LabelPosition", LabelPosition.ToResoniteReference(context));
members.Add("LabelScale", LabelScale.ToResoniteReference(context));
members.Add("LabelColorDrive", LabelColorDrive.ToResoniteReference(context));
}

}
            }
}
