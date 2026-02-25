
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GrabbablePermissions
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GrabbablePermissions")]
public partial class GrabbablePermissions : global::FrooxEngine.PermissionsComponent

{
    public global::FrooxEngine.TagFilter Tags;
public global::FrooxEngine.ListFilterMode ValidateTypeListMode;
public System.Collections.Generic.List<System.String> ValidateTypes;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Tags", new ResoniteLink.SyncObject() { Members = Tags.CollectMembers(context) });
members.Add("ValidateTypeListMode", ValidateTypeListMode.ToResoniteLinkField());
members.Add("ValidateTypes", new ResoniteLink.SyncList()
{
    Elements = ValidateTypes.ConvertList(m => m.ToResoniteLinkField())
});
}

}
}
