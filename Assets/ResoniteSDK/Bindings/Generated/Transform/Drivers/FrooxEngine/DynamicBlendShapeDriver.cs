
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DynamicBlendShapeDriver
// Generated on: pátek 13. února 2026 23:23:09
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
    Elements = BlendShapes.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() })
});
members.Add("_lastRenderer", new ResoniteLink.Reference() { });
}

}
}
