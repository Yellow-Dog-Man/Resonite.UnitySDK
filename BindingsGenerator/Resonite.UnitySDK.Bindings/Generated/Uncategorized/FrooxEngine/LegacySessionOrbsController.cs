
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacySessionOrbsController
// Generated on: středa 25. února 2026 16:14:41
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacySessionOrbsController")]
public partial class LegacySessionOrbsController : global::FrooxEngine.LegacyWorldOrbPlateManager

{
    public global::System.Int32 MaxOrbs;
public global::System.Boolean ShowHeadless;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MaxOrbs", MaxOrbs.ToResoniteLinkField());
members.Add("ShowHeadless", ShowHeadless.ToResoniteLinkField());
}

}
}
