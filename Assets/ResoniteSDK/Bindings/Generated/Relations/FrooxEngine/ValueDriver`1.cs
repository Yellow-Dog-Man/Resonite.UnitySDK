
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ValueDriver<>
// Generated on: úterý 24. února 2026 18:20:04
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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
