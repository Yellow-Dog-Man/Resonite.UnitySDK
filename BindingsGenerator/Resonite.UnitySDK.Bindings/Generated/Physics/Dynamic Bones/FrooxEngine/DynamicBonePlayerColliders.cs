
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DynamicBonePlayerColliders
// Generated on: čtvrtek 26. února 2026 15:08:03
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DynamicBonePlayerColliders")]
public partial class DynamicBonePlayerColliders : global::FrooxEngine.UserRootComponent

{
    public global::System.Boolean VisualizeColliders { get => VisualizeColliders_Element.Data; set => VisualizeColliders_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> VisualizeColliders_Element = new();
public global::System.Boolean DisableDefaultHeadColliders { get => DisableDefaultHeadColliders_Element.Data; set => DisableDefaultHeadColliders_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DisableDefaultHeadColliders_Element = new();
public global::System.Boolean DisableDefaultBodyColliders { get => DisableDefaultBodyColliders_Element.Data; set => DisableDefaultBodyColliders_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DisableDefaultBodyColliders_Element = new();
public global::System.Boolean DisableDefaultLeftHandColliders { get => DisableDefaultLeftHandColliders_Element.Data; set => DisableDefaultLeftHandColliders_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DisableDefaultLeftHandColliders_Element = new();
public global::System.Boolean DisableDefaultRightHandColliders { get => DisableDefaultRightHandColliders_Element.Data; set => DisableDefaultRightHandColliders_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DisableDefaultRightHandColliders_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.IDynamicBoneCollider>, global::FrooxEngine.IDynamicBoneCollider, Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IDynamicBoneCollider>, global::FrooxEngine.IDynamicBoneCollider>> Colliders = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("VisualizeColliders", VisualizeColliders_Element.ToLinkField(context));
members.Add("DisableDefaultHeadColliders", DisableDefaultHeadColliders_Element.ToLinkField(context));
members.Add("DisableDefaultBodyColliders", DisableDefaultBodyColliders_Element.ToLinkField(context));
members.Add("DisableDefaultLeftHandColliders", DisableDefaultLeftHandColliders_Element.ToLinkField(context));
members.Add("DisableDefaultRightHandColliders", DisableDefaultRightHandColliders_Element.ToLinkField(context));
members.Add("Colliders", Colliders.ToLinkList(context, m => m.ToLinkReference(context)));
}

}
}
