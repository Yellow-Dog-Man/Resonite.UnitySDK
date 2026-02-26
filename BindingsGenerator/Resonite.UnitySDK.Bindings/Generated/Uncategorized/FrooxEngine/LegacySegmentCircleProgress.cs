
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacySegmentCircleProgress
// Generated on: čtvrtek 26. února 2026 12:28:12
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacySegmentCircleProgress")]
public partial class LegacySegmentCircleProgress : global::FrooxEngine.Component

{
    public global::FrooxEngine.ProgressStage Stage { get => Stage_Element.Data; set => Stage_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ProgressStage>, global::FrooxEngine.ProgressStage> Stage_Element = new();
public global::FrooxEngine.TextRenderer _progressText { get => _progressText_Element.Data; set => _progressText_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.TextRenderer>, global::FrooxEngine.TextRenderer> _progressText_Element = new();
public global::FrooxEngine.TextRenderer _detailText { get => _detailText_Element.Data; set => _detailText_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.TextRenderer>, global::FrooxEngine.TextRenderer> _detailText_Element = new();
public global::FrooxEngine.UnlitMaterial _material { get => _material_Element.Data; set => _material_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UnlitMaterial>, global::FrooxEngine.UnlitMaterial> _material_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> _tint { get => _tint_Element.Data; set => _tint_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> _tint_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Stage", Stage_Element.ToLinkField(context));
members.Add("_progressText", _progressText_Element.ToLinkReference(context));
members.Add("_detailText", _detailText_Element.ToLinkReference(context));
members.Add("_material", _material_Element.ToLinkReference(context));
members.Add("_tint", _tint_Element.ToLinkReference(context));
}

}
}
