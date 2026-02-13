
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.NestedCanvas
// Generated on: pátek 13. února 2026 23:23:11
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.NestedCanvas")]
public partial class NestedCanvas : global::FrooxEngine.UIX.UIController, global::FrooxEngine.UIX.IUIInteractable

{
    public global::FrooxEngine.UIX.Canvas TargetCanvas;
public global::FrooxEngine.IField<global::System.Int32> _renderOffset;
public global::FrooxEngine.IField<global::System.Int32> _maskDepth;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TargetCanvas", new ResoniteLink.Reference() { });
members.Add("_renderOffset", new ResoniteLink.Reference() { });
members.Add("_maskDepth", new ResoniteLink.Reference() { });
}

}
}
