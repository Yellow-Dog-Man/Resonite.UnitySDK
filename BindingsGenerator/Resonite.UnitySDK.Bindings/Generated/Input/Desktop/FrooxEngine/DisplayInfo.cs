
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DisplayInfo
// Generated on: čtvrtek 26. února 2026 12:26:55
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DisplayInfo")]
public partial class DisplayInfo : global::FrooxEngine.Component

{
    public global::System.Int32 DisplayIndex { get => DisplayIndex_Element.Data; set => DisplayIndex_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> DisplayIndex_Element = new();
public UnityEngine.Vector2Int Resolution { get => Resolution_Element.Data; set => Resolution_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<UnityEngine.Vector2Int>, UnityEngine.Vector2Int> Resolution_Element = new();
public UnityEngine.Vector2Int Offset { get => Offset_Element.Data; set => Offset_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<UnityEngine.Vector2Int>, UnityEngine.Vector2Int> Offset_Element = new();
public UnityEngine.Vector2 DPI { get => DPI_Element.Data; set => DPI_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<UnityEngine.Vector2>, UnityEngine.Vector2> DPI_Element = new();
public global::System.Double RefreshRate { get => RefreshRate_Element.Data; set => RefreshRate_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Double>, global::System.Double> RefreshRate_Element = new();
public global::Renderite.Shared.RectOrientation Orientation { get => Orientation_Element.Data; set => Orientation_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::Renderite.Shared.RectOrientation>, global::Renderite.Shared.RectOrientation> Orientation_Element = new();
public global::System.Boolean IsPrimary { get => IsPrimary_Element.Data; set => IsPrimary_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> IsPrimary_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DisplayIndex", DisplayIndex_Element.ToLinkField(context));
members.Add("Resolution", Resolution_Element.ToLinkField(context));
members.Add("Offset", Offset_Element.ToLinkField(context));
members.Add("DPI", DPI_Element.ToLinkField(context));
members.Add("RefreshRate", RefreshRate_Element.ToLinkField(context));
members.Add("Orientation", Orientation_Element.ToLinkField(context));
members.Add("IsPrimary", IsPrimary_Element.ToLinkField(context));
}

}
}
