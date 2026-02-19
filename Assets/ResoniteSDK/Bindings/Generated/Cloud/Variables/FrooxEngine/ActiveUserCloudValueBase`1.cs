
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ActiveUserCloudValueBase<>
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ActiveUserCloudValueBase<>")]
public abstract partial class ActiveUserCloudValueBase<T> : global::FrooxEngine.CloudValueBase<T>
	

{
    public global::System.Boolean UpdateCloudVariable;
public T FallbackValue;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UpdateCloudVariable", UpdateCloudVariable.ToResoniteLinkField());
members.Add("FallbackValue", FallbackValue.ToResoniteLinkField());
}

}
}
