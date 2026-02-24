
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DynamicBlendShapeDriver
// Generated on: úterý 24. února 2026 18:20:13
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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
    public global::FrooxEngine.SkinnedMeshRenderer Renderer;
public System.Collections.Generic.List<global::FrooxEngine.DynamicBlendShapeDriver.BlendShape> BlendShapes;
public global::FrooxEngine.SkinnedMeshRenderer _lastRenderer;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Renderer", Renderer.ToResoniteReference(context));
members.Add("BlendShapes", new ResoniteLink.SyncList()
{
    Elements = BlendShapes.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("_lastRenderer", _lastRenderer.ToResoniteReference(context));
}

}
}
