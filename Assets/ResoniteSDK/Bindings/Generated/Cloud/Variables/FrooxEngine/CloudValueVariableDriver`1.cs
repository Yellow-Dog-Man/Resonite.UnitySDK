
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CloudValueVariableDriver<>
// Generated on: pátek 13. února 2026 23:21:37
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CloudValueVariableDriver<>")]
public partial class CloudValueVariableDriver<T> : global::FrooxEngine.CloudVariableBase
	

{
    public global::FrooxEngine.IField<T> Target;
public global::System.Boolean IsLinkedToCloud;
public global::System.Boolean WriteBack;
public T FallbackValue;
public global::System.String OverrideOwner;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Target", new ResoniteLink.Reference() { });
members.Add("IsLinkedToCloud", IsLinkedToCloud.ToResoniteLinkField());
members.Add("WriteBack", WriteBack.ToResoniteLinkField());
members.Add("FallbackValue", FallbackValue.ToResoniteLinkField());
members.Add("OverrideOwner", OverrideOwner.ToResoniteLinkField());
}

}
}
