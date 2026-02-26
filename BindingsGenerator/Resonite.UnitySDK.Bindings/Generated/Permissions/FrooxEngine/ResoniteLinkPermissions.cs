
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ResoniteLinkPermissions
// Generated on: čtvrtek 26. února 2026 15:08:02
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ResoniteLinkPermissions")]
public partial class ResoniteLinkPermissions : global::FrooxEngine.PermissionsComponent

{
    public global::System.Boolean AllowReadAccess { get => AllowReadAccess_Element.Data; set => AllowReadAccess_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AllowReadAccess_Element = new();
public global::System.Boolean AllowWriteAccess { get => AllowWriteAccess_Element.Data; set => AllowWriteAccess_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AllowWriteAccess_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AllowReadAccess", AllowReadAccess_Element.ToLinkField(context));
members.Add("AllowWriteAccess", AllowWriteAccess_Element.ToLinkField(context));
}

}
}
