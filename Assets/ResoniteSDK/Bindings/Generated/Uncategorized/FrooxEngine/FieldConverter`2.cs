
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FieldConverter<,>
// Generated on: pátek 13. února 2026 23:23:15
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FieldConverter<,>")]
public abstract partial class FieldConverter<I,O> : global::FrooxEngine.Component
	
	

{
    public global::FrooxEngine.IField<O> Target;
public I Value;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Target", new ResoniteLink.Reference() { });
members.Add("Value", Value.ToResoniteLinkField());
}

}
}
