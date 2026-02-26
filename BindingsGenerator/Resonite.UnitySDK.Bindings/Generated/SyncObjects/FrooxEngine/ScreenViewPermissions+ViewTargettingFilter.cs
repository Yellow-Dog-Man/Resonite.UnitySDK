
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ScreenViewPermissions+ViewTargettingFilter
// Generated on: čtvrtek 26. února 2026 10:03:41
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
    public partial class ScreenViewPermissions
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ScreenViewPermissions+ViewTargettingFilter")]
public partial class ViewTargettingFilter : global::FrooxEngine.SyncObject

{
    public System.String ViewTargettingType { get => ViewTargettingType_Element.Data; set => ViewTargettingType_Element.Data = value; }
public Field<global::FrooxEngine.SyncType, System.String> ViewTargettingType_Element = new();
public global::System.String RequireTag { get => RequireTag_Element.Data; set => RequireTag_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> RequireTag_Element = new();
public global::System.Boolean EditModeOnly { get => EditModeOnly_Element.Data; set => EditModeOnly_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> EditModeOnly_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ViewTargettingType", ViewTargettingType_Element.Data.ToResoniteLinkField());
members.Add("RequireTag", RequireTag_Element.Data.ToResoniteLinkField());
members.Add("EditModeOnly", EditModeOnly_Element.Data.ToResoniteLinkField());
}

}
            }
}
