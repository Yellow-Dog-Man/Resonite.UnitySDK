
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ResoniteLinkPermissions
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ResoniteLinkPermissions")]
public partial class ResoniteLinkPermissions : global::FrooxEngine.PermissionsComponent

{
    public global::System.Boolean AllowReadAccess;
public global::System.Boolean AllowWriteAccess;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AllowReadAccess", AllowReadAccess.ToResoniteLinkField());
members.Add("AllowWriteAccess", AllowWriteAccess.ToResoniteLinkField());
}

}
}
