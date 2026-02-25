
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BooleanSpatialVariableDriver
// Generated on: středa 25. února 2026 16:13:08
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BooleanSpatialVariableDriver")]
public partial class BooleanSpatialVariableDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<global::System.Boolean> Drive;
public global::System.String VariableName;
public global::FrooxEngine.BooleanSpatialVariableMode Mode;
public global::System.Boolean DefaultValue;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Drive", Drive.ToResoniteReference(context));
members.Add("VariableName", VariableName.ToResoniteLinkField());
members.Add("Mode", Mode.ToResoniteLinkField());
members.Add("DefaultValue", DefaultValue.ToResoniteLinkField());
}

}
}
