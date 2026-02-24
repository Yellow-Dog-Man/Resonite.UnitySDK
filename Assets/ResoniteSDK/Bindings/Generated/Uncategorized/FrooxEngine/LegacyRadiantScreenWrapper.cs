
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyRadiantScreenWrapper
// Generated on: úterý 24. února 2026 18:20:24
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyRadiantScreenWrapper")]
public abstract partial class LegacyRadiantScreenWrapper : global::FrooxEngine.RadiantDashScreen

{
    public global::System.Single ExtraSidePadding;
public UnityEngine.ColorX Background;
public global::System.Boolean _initialized;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ExtraSidePadding", ExtraSidePadding.ToResoniteLinkField());
members.Add("Background", Background.ToResoniteLinkField());
members.Add("_initialized", _initialized.ToResoniteLinkField());
}

}
}
