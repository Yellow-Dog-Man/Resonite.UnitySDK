
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ReferenceField<>
// Generated on: pátek 13. února 2026 5:51:11
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ReferenceField<>")]
public partial class ReferenceField<T> : global::FrooxEngine.Component, global::FrooxEngine.IReferenceSource<T>, global::FrooxEngine.IReferenceSource
	where T : class, global::FrooxEngine.IWorldElement

{
    public T Reference;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Reference", new ResoniteLink.Reference() { });
}

}
}
