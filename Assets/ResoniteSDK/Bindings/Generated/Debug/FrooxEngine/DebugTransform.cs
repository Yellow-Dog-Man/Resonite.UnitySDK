
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DebugTransform
// Generated on: čtvrtek 19. února 2026 7:58:58
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DebugTransform")]
public partial class DebugTransform : global::FrooxEngine.Component

{
    public global::FrooxEngine.UserRef ShowToUser;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ShowToUser", new ResoniteLink.SyncObject() { Members = ShowToUser.CollectMembers(context) });
}

}
}
