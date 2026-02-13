
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MeshRendererMaterialRelay
// Generated on: pátek 13. února 2026 23:21:36
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MeshRendererMaterialRelay")]
public partial class MeshRendererMaterialRelay : global::FrooxEngine.Component, global::FrooxEngine.IMaterialTarget, global::FrooxEngine.IMaterialSource

{
    public System.Collections.Generic.List<global::FrooxEngine.MeshRenderer> Renderers;
public global::FrooxEngine.MeshRenderer _renderer;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Renderers", new ResoniteLink.SyncList()
{
    Elements = Renderers.ConvertList(m => new ResoniteLink.Reference() { })
});
members.Add("_renderer", new ResoniteLink.Reference() { });
}

}
}
