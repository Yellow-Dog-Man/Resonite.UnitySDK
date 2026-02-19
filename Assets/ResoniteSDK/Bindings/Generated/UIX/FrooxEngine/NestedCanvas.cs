
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.NestedCanvas
// Generated on: čtvrtek 19. února 2026 8:00:25
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.NestedCanvas")]
public partial class NestedCanvas : global::FrooxEngine.UIX.UIController, global::FrooxEngine.UIX.IUIInteractable

{
    public global::FrooxEngine.UIX.Canvas TargetCanvas;
public global::FrooxEngine.IField<global::System.Int32> _renderOffset;
public global::FrooxEngine.IField<global::System.Int32> _maskDepth;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetCanvas", TargetCanvas.ToResoniteReference(context));
members.Add("_renderOffset", _renderOffset.ToResoniteReference(context));
members.Add("_maskDepth", _maskDepth.ToResoniteReference(context));
}

}
}
