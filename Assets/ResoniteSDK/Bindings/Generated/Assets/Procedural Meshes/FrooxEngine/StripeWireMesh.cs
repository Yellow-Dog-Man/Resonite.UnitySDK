
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.StripeWireMesh
// Generated on: pátek 13. února 2026 23:21:35
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.StripeWireMesh")]
public partial class StripeWireMesh : global::FrooxEngine.WireMeshBase

{
    public global::System.Single Width0;
public global::System.Single Width1;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Width0", Width0.ToResoniteLinkField());
members.Add("Width1", Width1.ToResoniteLinkField());
}

}
}
