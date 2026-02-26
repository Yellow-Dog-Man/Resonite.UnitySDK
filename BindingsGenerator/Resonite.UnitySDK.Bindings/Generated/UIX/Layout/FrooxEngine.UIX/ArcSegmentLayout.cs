
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.ArcSegmentLayout
// Generated on: čtvrtek 26. února 2026 15:09:09
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.UIX
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.ArcSegmentLayout")]
public partial class ArcSegmentLayout : global::FrooxEngine.UIX.LayoutController

{
    public global::FrooxEngine.UIX.RectTransform Nested { get => Nested_Element.Data; set => Nested_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.RectTransform>, global::FrooxEngine.UIX.RectTransform> Nested_Element = new();
public global::System.Single NestedSizeRatio { get => NestedSizeRatio_Element.Data; set => NestedSizeRatio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NestedSizeRatio_Element = new();
public global::FrooxEngine.UIX.Text Label { get => Label_Element.Data; set => Label_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> Label_Element = new();
public UnityEngine.Vector2 LabelSize { get => LabelSize_Element.Data; set => LabelSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> LabelSize_Element = new();
public global::System.Single LabelDistance { get => LabelDistance_Element.Data; set => LabelDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> LabelDistance_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Nested", Nested_Element.ToLinkReference(context));
members.Add("NestedSizeRatio", NestedSizeRatio_Element.ToLinkField(context));
members.Add("Label", Label_Element.ToLinkReference(context));
members.Add("LabelSize", LabelSize_Element.ToLinkField(context));
members.Add("LabelDistance", LabelDistance_Element.ToLinkField(context));
}

}
}
