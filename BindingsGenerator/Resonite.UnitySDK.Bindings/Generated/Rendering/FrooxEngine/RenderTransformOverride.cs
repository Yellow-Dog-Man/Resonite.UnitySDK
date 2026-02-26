
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RenderTransformOverride
// Generated on: čtvrtek 26. února 2026 15:09:03
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
public global::SyncFieldList<global::FrooxEngine.SyncRelayList<global::FrooxEngine.SkinnedMeshRenderer>, global::FrooxEngine.SkinnedMeshRenderer, Reference<global::FrooxEngine.RelayRef<global::FrooxEngine.SkinnedMeshRenderer>, global::FrooxEngine.SkinnedMeshRenderer>> SkinnedMeshRenderers = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PositionOverride", PositionOverride_Element.ToLinkField(context));
members.Add("RotationOverride", RotationOverride_Element.ToLinkField(context));
members.Add("ScaleOverride", ScaleOverride_Element.ToLinkField(context));
members.Add("SkinnedMeshRenderers", SkinnedMeshRenderers.ToLinkList(context, m => m.ToLinkReference(context)));
}

}
}
