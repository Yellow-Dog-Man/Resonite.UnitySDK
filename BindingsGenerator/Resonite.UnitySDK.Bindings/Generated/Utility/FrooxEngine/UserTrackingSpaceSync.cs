
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserTrackingSpaceSync
// Generated on: čtvrtek 26. února 2026 10:04:50
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UserTrackingSpaceSync")]
public partial class UserTrackingSpaceSync : global::FrooxEngine.Component

{
    public global::System.Boolean SeatedMode { get => SeatedMode_Element.Data; set => SeatedMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SeatedMode_Element = new();
public global::System.Single UserHeight { get => UserHeight_Element.Data; set => UserHeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> UserHeight_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SeatedMode", SeatedMode_Element.Data.ToResoniteLinkField());
members.Add("UserHeight", UserHeight_Element.Data.ToResoniteLinkField());
}

}
}
