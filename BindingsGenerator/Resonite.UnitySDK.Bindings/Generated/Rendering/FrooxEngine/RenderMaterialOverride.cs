
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RenderMaterialOverride
// Generated on: pátek 6. března 2026 14:19:03
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RenderMaterialOverride")]
public partial class RenderMaterialOverride : global::FrooxEngine.RenderContextOverride

{
    public global::FrooxEngine.MeshRenderer Renderer { get => Renderer_Element.Data; set => Renderer_Element.Data = value; }
public Reference<global::FrooxEngine.RelayRef<global::FrooxEngine.MeshRenderer>, global::FrooxEngine.MeshRenderer> Renderer_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.RenderMaterialOverride.MaterialOverride>, global::FrooxEngine.RenderMaterialOverride.MaterialOverride> Overrides = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Renderer", Renderer_Element.ToLinkReference(context));
members.Add("Overrides", Overrides.ToLinkList(context, m => m.ToLinkSyncObject(context)));
}

}
}
