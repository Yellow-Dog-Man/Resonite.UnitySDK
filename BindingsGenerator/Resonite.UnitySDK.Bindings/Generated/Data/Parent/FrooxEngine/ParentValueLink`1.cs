
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ParentValueLink<>
// Generated on: středa 25. února 2026 16:13:07
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
