
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DynamicBlendShapeDriver
// Generated on: čtvrtek 26. února 2026 15:09:07
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DynamicBlendShapeDriver")]
public partial class DynamicBlendShapeDriver : global::FrooxEngine.Component, global::FrooxEngine.ICustomInspector

{
    public global::FrooxEngine.SkinnedMeshRenderer Renderer { get => Renderer_Element.Data; set => Renderer_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.SkinnedMeshRenderer>, global::FrooxEngine.SkinnedMeshRenderer> Renderer_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.DynamicBlendShapeDriver.BlendShape>, global::FrooxEngine.DynamicBlendShapeDriver.BlendShape> BlendShapes = new();
public global::FrooxEngine.SkinnedMeshRenderer _lastRenderer { get => _lastRenderer_Element.Data; set => _lastRenderer_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.SkinnedMeshRenderer>, global::FrooxEngine.SkinnedMeshRenderer> _lastRenderer_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Renderer", Renderer_Element.ToLinkReference(context));
members.Add("BlendShapes", BlendShapes.ToLinkList(context, m => m.ToLinkSyncObject(context)));
members.Add("_lastRenderer", _lastRenderer_Element.ToLinkReference(context));
}

}
}
