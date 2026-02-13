
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Float4Driver
// Generated on: pátek 13. února 2026 23:23:09
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Float4Driver")]
public partial class Float4Driver : global::FrooxEngine.Component

{
    public global::FrooxEngine.Sync<global::System.Single> X;
public global::FrooxEngine.Sync<global::System.Single> Y;
public global::FrooxEngine.Sync<global::System.Single> Z;
public global::FrooxEngine.Sync<global::System.Single> W;
public global::FrooxEngine.IField<UnityEngine.Vector4> Target;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("X", new ResoniteLink.Reference() { });
members.Add("Y", new ResoniteLink.Reference() { });
members.Add("Z", new ResoniteLink.Reference() { });
members.Add("W", new ResoniteLink.Reference() { });
members.Add("Target", new ResoniteLink.Reference() { });
}

}
}
