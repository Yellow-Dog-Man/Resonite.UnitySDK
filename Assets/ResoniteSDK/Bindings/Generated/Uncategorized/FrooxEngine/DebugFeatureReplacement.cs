
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DebugFeatureReplacement
// Generated on: pátek 13. února 2026 5:52:30
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DebugFeatureReplacement")]
public partial class DebugFeatureReplacement : global::FrooxEngine.Component

{
    public global::System.Int32 Test;
public global::System.Single Test2;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Test", Test.ToResoniteLinkField());
members.Add("Test2", Test2.ToResoniteLinkField());
}

}
}
