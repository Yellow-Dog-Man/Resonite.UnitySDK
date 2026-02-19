
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WorldConfigurationPermissions
// Generated on: čtvrtek 19. února 2026 8:00:32
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.WorldConfigurationPermissions")]
public partial class WorldConfigurationPermissions : global::FrooxEngine.PermissionsComponent

{
    public global::System.Boolean AllowChanges;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AllowChanges", AllowChanges.ToResoniteLinkField());
}

}
}
