
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacySegmentCircleMenuController+Item
// Generated on: pátek 13. února 2026 23:23:07
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Enabled", Enabled.ToResoniteLinkField());
members.Add("AngleStart", AngleStart.ToResoniteLinkField());
members.Add("RadiusStart", RadiusStart.ToResoniteLinkField());
members.Add("ArcLength", ArcLength.ToResoniteLinkField());
members.Add("Thickness", Thickness.ToResoniteLinkField());
members.Add("Label", new ResoniteLink.Reference() { });
members.Add("LabelColor", LabelColor.ToResoniteLinkField());
members.Add("OutlineColor", OutlineColor.ToResoniteLinkField());
members.Add("FillColor", FillColor.ToResoniteLinkField());
members.Add("IconMaterial", new ResoniteLink.Reference() { });
members.Add("IconTexture", new ResoniteLink.Reference() { });
members.Add("RotateIcon", RotateIcon.ToResoniteLinkField());
members.Add("IconRoot", new ResoniteLink.Reference() { });
members.Add("Highlight", Highlight.ToResoniteLinkField());
members.Add("IconPosition", new ResoniteLink.Reference() { });
members.Add("IconRotation", new ResoniteLink.Reference() { });
members.Add("IconScale", new ResoniteLink.Reference() { });
members.Add("ColliderRoot", new ResoniteLink.Reference() { });
members.Add("ColliderPosition", new ResoniteLink.Reference() { });
members.Add("ColliderScale", new ResoniteLink.Reference() { });
members.Add("ColliderRotation", new ResoniteLink.Reference() { });
members.Add("LastPress", LastPress.ToResoniteLinkField());
members.Add("LabelRoot", new ResoniteLink.Reference() { });
members.Add("LabelPosition", new ResoniteLink.Reference() { });
members.Add("LabelScale", new ResoniteLink.Reference() { });
members.Add("LabelColorDrive", new ResoniteLink.Reference() { });
}

}
            }
}
