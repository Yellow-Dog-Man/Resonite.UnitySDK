
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacySessionOrbsController
// Generated on: čtvrtek 26. února 2026 10:04:46
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
    public global::System.Int32 MaxOrbs { get => MaxOrbs_Element.Data; set => MaxOrbs_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> MaxOrbs_Element = new();
public global::System.Boolean ShowHeadless { get => ShowHeadless_Element.Data; set => ShowHeadless_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ShowHeadless_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MaxOrbs", MaxOrbs_Element.Data.ToResoniteLinkField());
members.Add("ShowHeadless", ShowHeadless_Element.Data.ToResoniteLinkField());
}

}
}
