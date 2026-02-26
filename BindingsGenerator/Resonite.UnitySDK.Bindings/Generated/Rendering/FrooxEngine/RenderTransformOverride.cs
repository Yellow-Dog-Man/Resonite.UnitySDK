
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RenderTransformOverride
// Generated on: čtvrtek 26. února 2026 10:04:37
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
    public global::System.Nullable<UnityEngine.Vector3> PositionOverride { get => PositionOverride_Element.Data; set => PositionOverride_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<UnityEngine.Vector3>>, global::System.Nullable<UnityEngine.Vector3>> PositionOverride_Element = new();
public global::System.Nullable<UnityEngine.Quaternion> RotationOverride { get => RotationOverride_Element.Data; set => RotationOverride_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<UnityEngine.Quaternion>>, global::System.Nullable<UnityEngine.Quaternion>> RotationOverride_Element = new();
public global::System.Nullable<UnityEngine.Vector3> ScaleOverride { get => ScaleOverride_Element.Data; set => ScaleOverride_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<UnityEngine.Vector3>>, global::System.Nullable<UnityEngine.Vector3>> ScaleOverride_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncRelayList<global::FrooxEngine.SkinnedMeshRenderer>, global::FrooxEngine.SkinnedMeshRenderer, Field<global::FrooxEngine.RelayRef<global::FrooxEngine.SkinnedMeshRenderer>, global::FrooxEngine.SkinnedMeshRenderer>> SkinnedMeshRenderers = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PositionOverride", PositionOverride_Element.Data.ToResoniteLinkField());
members.Add("RotationOverride", RotationOverride_Element.Data.ToResoniteLinkField());
members.Add("ScaleOverride", ScaleOverride_Element.Data.ToResoniteLinkField());
members.Add("SkinnedMeshRenderers", new ResoniteLink.SyncList()
{
    Elements = SkinnedMeshRenderers.Data.ConvertList(m => m.Data.ToResoniteReference(context))
});
}

}
}
