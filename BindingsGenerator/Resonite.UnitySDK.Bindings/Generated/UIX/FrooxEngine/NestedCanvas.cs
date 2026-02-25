
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.NestedCanvas
// Generated on: středa 25. února 2026 16:14:33
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
