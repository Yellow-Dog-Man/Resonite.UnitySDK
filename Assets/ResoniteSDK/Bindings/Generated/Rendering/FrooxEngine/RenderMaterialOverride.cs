
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RenderMaterialOverride
// Generated on: pátek 13. února 2026 23:23:04
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RenderMaterialOverride")]
public partial class RenderMaterialOverride : global::FrooxEngine.RenderContextOverride

{
    public global::FrooxEngine.MeshRenderer Renderer;
public System.Collections.Generic.List<global::FrooxEngine.RenderMaterialOverride.MaterialOverride> Overrides;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Renderer", new ResoniteLink.Reference() { });
members.Add("Overrides", new ResoniteLink.SyncList()
{
    Elements = Overrides.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() })
});
}

}
}
