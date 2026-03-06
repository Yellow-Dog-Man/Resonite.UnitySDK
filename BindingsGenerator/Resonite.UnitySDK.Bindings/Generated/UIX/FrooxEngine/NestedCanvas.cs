
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.NestedCanvas
// Generated on: pátek 6. března 2026 14:19:07
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
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
    public global::FrooxEngine.UIX.Canvas TargetCanvas { get => TargetCanvas_Element.Data; set => TargetCanvas_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Canvas>, global::FrooxEngine.UIX.Canvas> TargetCanvas_Element = new();
public global::FrooxEngine.IField<global::System.Int32> _renderOffset { get => _renderOffset_Element.Data; set => _renderOffset_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Int32>, global::FrooxEngine.IField<global::System.Int32>> _renderOffset_Element = new();
public global::FrooxEngine.IField<global::System.Int32> _maskDepth { get => _maskDepth_Element.Data; set => _maskDepth_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Int32>, global::FrooxEngine.IField<global::System.Int32>> _maskDepth_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetCanvas", TargetCanvas_Element.ToLinkReference(context));
members.Add("_renderOffset", _renderOffset_Element.ToLinkReference(context));
members.Add("_maskDepth", _maskDepth_Element.ToLinkReference(context));
}

}
}
