
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyWorldListManager+SortProperty
// Generated on: čtvrtek 19. února 2026 8:00:18
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
    public partial class LegacyWorldListManager
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyWorldListManager+SortProperty")]
public partial class SortProperty : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.LegacyWorldListManager.SortParameter Parameter;
public global::FrooxEngine.LegacyWorldListManager.SortDirection Direction;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Parameter", Parameter.ToResoniteLinkField());
members.Add("Direction", Direction.ToResoniteLinkField());
}

}
            }
}
