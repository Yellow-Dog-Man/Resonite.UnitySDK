
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CloudValueVariableDriver<>
// Generated on: čtvrtek 19. února 2026 7:58:55
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CloudValueVariableDriver<>")]
public partial class CloudValueVariableDriver<T> : global::FrooxEngine.CloudVariableBase
	

{
    public global::FrooxEngine.IField<T> Target;
public global::System.Boolean IsLinkedToCloud;
public global::System.Boolean WriteBack;
public T FallbackValue;
public global::System.String OverrideOwner;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target.ToResoniteReference(context));
members.Add("IsLinkedToCloud", IsLinkedToCloud.ToResoniteLinkField());
members.Add("WriteBack", WriteBack.ToResoniteLinkField());
members.Add("FallbackValue", FallbackValue.ToResoniteLinkField());
members.Add("OverrideOwner", OverrideOwner.ToResoniteLinkField());
}

}
}
