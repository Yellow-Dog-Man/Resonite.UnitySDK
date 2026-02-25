
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ValueDriver<>
// Generated on: středa 25. února 2026 16:14:15
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ValueDriver<>")]
public partial class ValueDriver<T> : global::FrooxEngine.Component
	

{
    public global::FrooxEngine.IValue<T> ValueSource;
public global::FrooxEngine.IField<T> DriveTarget;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ValueSource", ValueSource.ToResoniteReference(context));
members.Add("DriveTarget", DriveTarget.ToResoniteReference(context));
}

}
}
