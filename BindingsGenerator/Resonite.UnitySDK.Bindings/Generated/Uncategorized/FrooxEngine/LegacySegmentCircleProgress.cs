
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacySegmentCircleProgress
// Generated on: středa 25. února 2026 16:14:41
// Resonite version: 2026.2.25.455
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
    public global::FrooxEngine.ProgressStage Stage;
public global::FrooxEngine.TextRenderer _progressText;
public global::FrooxEngine.TextRenderer _detailText;
public global::FrooxEngine.UnlitMaterial _material;
public global::FrooxEngine.IField<UnityEngine.ColorX> _tint;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Stage", Stage.ToResoniteLinkField());
members.Add("_progressText", _progressText.ToResoniteReference(context));
members.Add("_detailText", _detailText.ToResoniteReference(context));
members.Add("_material", _material.ToResoniteReference(context));
members.Add("_tint", _tint.ToResoniteReference(context));
}

}
}
