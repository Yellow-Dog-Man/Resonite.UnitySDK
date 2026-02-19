
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyCanvasPanel
// Generated on: čtvrtek 19. února 2026 8:00:28
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyCanvasPanel")]
public partial class LegacyCanvasPanel : global::FrooxEngine.Component

{
    public global::FrooxEngine.UIX.Canvas _canvas;
public global::FrooxEngine.LegacyPanel _panel;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_canvas", _canvas.ToResoniteReference(context));
members.Add("_panel", _panel.ToResoniteReference(context));
}

}
}
