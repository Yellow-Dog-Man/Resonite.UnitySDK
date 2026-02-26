
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyCanvasPanel
// Generated on: čtvrtek 26. února 2026 12:28:11
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyCanvasPanel")]
public partial class LegacyCanvasPanel : global::FrooxEngine.Component

{
    public global::FrooxEngine.UIX.Canvas _canvas { get => _canvas_Element.Data; set => _canvas_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Canvas>, global::FrooxEngine.UIX.Canvas> _canvas_Element = new();
public global::FrooxEngine.LegacyPanel _panel { get => _panel_Element.Data; set => _panel_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.LegacyPanel>, global::FrooxEngine.LegacyPanel> _panel_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_canvas", _canvas_Element.ToLinkReference(context));
members.Add("_panel", _panel_Element.ToLinkReference(context));
}

}
}
