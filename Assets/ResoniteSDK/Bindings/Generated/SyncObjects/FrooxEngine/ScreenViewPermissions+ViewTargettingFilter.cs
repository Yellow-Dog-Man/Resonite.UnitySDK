
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ScreenViewPermissions+ViewTargettingFilter
// Generated on: pátek 13. února 2026 23:21:42
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
    public partial class ScreenViewPermissions
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ScreenViewPermissions+ViewTargettingFilter")]
public partial class ViewTargettingFilter : global::FrooxEngine.SyncObject

{
    public System.String ViewTargettingType;
public global::System.String RequireTag;
public global::System.Boolean EditModeOnly;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ViewTargettingType", ViewTargettingType.ToResoniteLinkField());
members.Add("RequireTag", RequireTag.ToResoniteLinkField());
members.Add("EditModeOnly", EditModeOnly.ToResoniteLinkField());
}

}
            }
}
