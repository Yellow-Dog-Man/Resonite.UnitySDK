
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FlipAtUser
// Generated on: sobota 14. února 2026 8:58:39
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FlipAtUser")]
public partial class FlipAtUser : global::FrooxEngine.Component

{
    public global::FrooxEngine.RootSpace UpSpace;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _rotation;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UpSpace", new ResoniteLink.SyncObject() { Members = UpSpace.CollectMembers(context) });
members.Add("_rotation", _rotation.ToResoniteReference(context));
}

}
}
