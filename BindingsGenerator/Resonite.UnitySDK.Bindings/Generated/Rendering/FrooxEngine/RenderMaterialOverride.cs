
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RenderMaterialOverride
// Generated on: středa 25. února 2026 16:14:17
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RenderMaterialOverride")]
public partial class RenderMaterialOverride : global::FrooxEngine.RenderContextOverride

{
    public global::FrooxEngine.MeshRenderer Renderer;
public System.Collections.Generic.List<global::FrooxEngine.RenderMaterialOverride.MaterialOverride> Overrides;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Renderer", Renderer.ToResoniteReference(context));
members.Add("Overrides", new ResoniteLink.SyncList()
{
    Elements = Overrides.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
