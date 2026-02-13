
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LODGroup+LOD
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
    public partial class LODGroup
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LODGroup+LOD")]
public partial class LOD : global::FrooxEngine.SyncObject

{
    public global::System.Single ScreenRelativeTransitionHeight;
public global::System.Single FadeTransitionWidth;
public System.Collections.Generic.List<global::FrooxEngine.MeshRenderer> Renderers;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ScreenRelativeTransitionHeight", ScreenRelativeTransitionHeight.ToResoniteLinkField());
members.Add("FadeTransitionWidth", FadeTransitionWidth.ToResoniteLinkField());
members.Add("Renderers", new ResoniteLink.SyncList()
{
    Elements = Renderers.ConvertList(m => new ResoniteLink.Reference() { })
});
}

}
            }
}
