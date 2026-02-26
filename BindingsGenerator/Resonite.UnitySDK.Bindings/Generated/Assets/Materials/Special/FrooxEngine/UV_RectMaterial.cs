
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UV_RectMaterial
// Generated on: čtvrtek 26. února 2026 12:26:48
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UV_RectMaterial")]
public partial class UV_RectMaterial : global::FrooxEngine.SingleShaderMaterialProvider

{
    public UnityEngine.Rect Rect { get => Rect_Element.Data; set => Rect_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Rect>, UnityEngine.Rect> Rect_Element = new();
public UnityEngine.ColorX OuterColor { get => OuterColor_Element.Data; set => OuterColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> OuterColor_Element = new();
public UnityEngine.ColorX InnerColor { get => InnerColor_Element.Data; set => InnerColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> InnerColor_Element = new();
public global::System.Nullable<UnityEngine.Rect> ClipRect { get => ClipRect_Element.Data; set => ClipRect_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<UnityEngine.Rect>>, global::System.Nullable<UnityEngine.Rect>> ClipRect_Element = new();
public global::FrooxEngine.BlendMode BlendMode { get => BlendMode_Element.Data; set => BlendMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.BlendMode>, global::FrooxEngine.BlendMode> BlendMode_Element = new();
public global::FrooxEngine.Sidedness Sidedness { get => Sidedness_Element.Data; set => Sidedness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.Sidedness>, global::FrooxEngine.Sidedness> Sidedness_Element = new();
public global::FrooxEngine.ZWrite ZWrite { get => ZWrite_Element.Data; set => ZWrite_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ZWrite>, global::FrooxEngine.ZWrite> ZWrite_Element = new();
public global::FrooxEngine.ZTest ZTest { get => ZTest_Element.Data; set => ZTest_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ZTest>, global::FrooxEngine.ZTest> ZTest_Element = new();
public global::System.Single OffsetFactor { get => OffsetFactor_Element.Data; set => OffsetFactor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> OffsetFactor_Element = new();
public global::System.Single OffsetUnits { get => OffsetUnits_Element.Data; set => OffsetUnits_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> OffsetUnits_Element = new();
public global::System.Int32 RenderQueue { get => RenderQueue_Element.Data; set => RenderQueue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> RenderQueue_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Rect", Rect_Element.ToLinkField(context));
members.Add("OuterColor", OuterColor_Element.ToLinkField(context));
members.Add("InnerColor", InnerColor_Element.ToLinkField(context));
members.Add("ClipRect", ClipRect_Element.ToLinkField(context));
members.Add("BlendMode", BlendMode_Element.ToLinkField(context));
members.Add("Sidedness", Sidedness_Element.ToLinkField(context));
members.Add("ZWrite", ZWrite_Element.ToLinkField(context));
members.Add("ZTest", ZTest_Element.ToLinkField(context));
members.Add("OffsetFactor", OffsetFactor_Element.ToLinkField(context));
members.Add("OffsetUnits", OffsetUnits_Element.ToLinkField(context));
members.Add("RenderQueue", RenderQueue_Element.ToLinkField(context));
}

}
}
