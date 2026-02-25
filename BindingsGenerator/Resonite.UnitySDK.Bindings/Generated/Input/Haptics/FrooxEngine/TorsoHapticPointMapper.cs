
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TorsoHapticPointMapper
// Generated on: středa 25. února 2026 16:13:09
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TorsoHapticPointMapper")]
public partial class TorsoHapticPointMapper : global::FrooxEngine.BoneChainHapticPointMapper

{
    public global::System.Single LowerWidth;
public global::System.Single UpperWidth;
public global::System.Single FrontOffset;
public global::System.Single BackOffset;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LowerWidth", LowerWidth.ToResoniteLinkField());
members.Add("UpperWidth", UpperWidth.ToResoniteLinkField());
members.Add("FrontOffset", FrontOffset.ToResoniteLinkField());
members.Add("BackOffset", BackOffset.ToResoniteLinkField());
}

}
}
