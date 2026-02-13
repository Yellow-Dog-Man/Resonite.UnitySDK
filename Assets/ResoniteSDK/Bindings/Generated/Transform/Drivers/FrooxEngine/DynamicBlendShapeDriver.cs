
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DynamicBlendShapeDriver
// Generated on: pátek 13. února 2026 5:52:25
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DynamicBlendShapeDriver")]
public partial class DynamicBlendShapeDriver : global::FrooxEngine.Component, global::FrooxEngine.ICustomInspector

{
    public global::FrooxEngine.SkinnedMeshRenderer Renderer;
public System.Collections.Generic.List<global::FrooxEngine.DynamicBlendShapeDriver.BlendShape> BlendShapes;
public global::FrooxEngine.SkinnedMeshRenderer _lastRenderer;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Renderer", new ResoniteLink.Reference() { });
members.Add("BlendShapes", new ResoniteLink.SyncList()
{
    Elements = BlendShapes.Select(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() }).ToList<ResoniteLink.Member>()
});
members.Add("_lastRenderer", new ResoniteLink.Reference() { });
}

}
}
