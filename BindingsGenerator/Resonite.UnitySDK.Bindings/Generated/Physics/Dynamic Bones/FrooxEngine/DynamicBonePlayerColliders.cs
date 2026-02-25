
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DynamicBonePlayerColliders
// Generated on: středa 25. února 2026 16:13:11
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DynamicBonePlayerColliders")]
public partial class DynamicBonePlayerColliders : global::FrooxEngine.UserRootComponent

{
    public global::System.Boolean VisualizeColliders;
public global::System.Boolean DisableDefaultHeadColliders;
public global::System.Boolean DisableDefaultBodyColliders;
public global::System.Boolean DisableDefaultLeftHandColliders;
public global::System.Boolean DisableDefaultRightHandColliders;
public System.Collections.Generic.List<global::FrooxEngine.IDynamicBoneCollider> Colliders;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("VisualizeColliders", VisualizeColliders.ToResoniteLinkField());
members.Add("DisableDefaultHeadColliders", DisableDefaultHeadColliders.ToResoniteLinkField());
members.Add("DisableDefaultBodyColliders", DisableDefaultBodyColliders.ToResoniteLinkField());
members.Add("DisableDefaultLeftHandColliders", DisableDefaultLeftHandColliders.ToResoniteLinkField());
members.Add("DisableDefaultRightHandColliders", DisableDefaultRightHandColliders.ToResoniteLinkField());
members.Add("Colliders", new ResoniteLink.SyncList()
{
    Elements = Colliders.ConvertList(m => m.ToResoniteReference(context))
});
}

}
}
