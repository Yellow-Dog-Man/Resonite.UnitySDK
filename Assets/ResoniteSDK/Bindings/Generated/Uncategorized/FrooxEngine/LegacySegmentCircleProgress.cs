
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacySegmentCircleProgress
// Generated on: pátek 13. února 2026 23:23:16
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacySegmentCircleProgress")]
public partial class LegacySegmentCircleProgress : global::FrooxEngine.Component

{
    public global::FrooxEngine.ProgressStage Stage;
public global::FrooxEngine.TextRenderer _progressText;
public global::FrooxEngine.TextRenderer _detailText;
public global::FrooxEngine.UnlitMaterial _material;
public global::FrooxEngine.IField<UnityEngine.ColorX> _tint;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Stage", Stage.ToResoniteLinkField());
members.Add("_progressText", new ResoniteLink.Reference() { });
members.Add("_detailText", new ResoniteLink.Reference() { });
members.Add("_material", new ResoniteLink.Reference() { });
members.Add("_tint", new ResoniteLink.Reference() { });
}

}
}
