
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ParentValueLink<>
// Generated on: čtvrtek 19. února 2026 7:58:57
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ParentValueLink<>")]
public partial class ParentValueLink<T> : global::FrooxEngine.ParentDataLink<T>
	

{
    public global::FrooxEngine.IField<T> Target;
public global::System.Boolean WriteBack;
public T DefaultValue;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target.ToResoniteReference(context));
members.Add("WriteBack", WriteBack.ToResoniteLinkField());
members.Add("DefaultValue", DefaultValue.ToResoniteLinkField());
}

}
}
