
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RenderTransformOverride
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RenderTransformOverride")]
public partial class RenderTransformOverride : global::FrooxEngine.RenderContextOverride

{
    public global::System.Nullable<UnityEngine.Vector3> PositionOverride;
public global::System.Nullable<UnityEngine.Quaternion> RotationOverride;
public global::System.Nullable<UnityEngine.Vector3> ScaleOverride;
public System.Collections.Generic.List<global::FrooxEngine.SkinnedMeshRenderer> SkinnedMeshRenderers;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PositionOverride", PositionOverride.ToResoniteLinkField());
members.Add("RotationOverride", RotationOverride.ToResoniteLinkField());
members.Add("ScaleOverride", ScaleOverride.ToResoniteLinkField());
members.Add("SkinnedMeshRenderers", new ResoniteLink.SyncList()
{
    Elements = SkinnedMeshRenderers.ConvertList(m => m.ToResoniteReference(context))
});
}

}
}
