
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LODGroup+LOD
// Generated on: čtvrtek 19. února 2026 8:00:19
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    public partial class LODGroup
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LODGroup+LOD")]
public partial class LOD : global::FrooxEngine.SyncObject

{
    public global::System.Single ScreenRelativeTransitionHeight;
public global::System.Single FadeTransitionWidth;
public System.Collections.Generic.List<global::FrooxEngine.MeshRenderer> Renderers;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ScreenRelativeTransitionHeight", ScreenRelativeTransitionHeight.ToResoniteLinkField());
members.Add("FadeTransitionWidth", FadeTransitionWidth.ToResoniteLinkField());
members.Add("Renderers", new ResoniteLink.SyncList()
{
    Elements = Renderers.ConvertList(m => m.ToResoniteReference(context))
});
}

}
            }
}
