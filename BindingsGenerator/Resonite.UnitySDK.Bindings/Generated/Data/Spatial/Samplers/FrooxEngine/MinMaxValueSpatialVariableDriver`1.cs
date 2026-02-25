
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MinMaxValueSpatialVariableDriver<>
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MinMaxValueSpatialVariableDriver<>")]
public partial class MinMaxValueSpatialVariableDriver<T> : global::FrooxEngine.Component
	

{
    public global::FrooxEngine.IField<T> MinDrive;
public global::FrooxEngine.IField<T> MaxDrive;
public global::System.String VariableName;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MinDrive", MinDrive.ToResoniteReference(context));
members.Add("MaxDrive", MaxDrive.ToResoniteReference(context));
members.Add("VariableName", VariableName.ToResoniteLinkField());
}

}
}
