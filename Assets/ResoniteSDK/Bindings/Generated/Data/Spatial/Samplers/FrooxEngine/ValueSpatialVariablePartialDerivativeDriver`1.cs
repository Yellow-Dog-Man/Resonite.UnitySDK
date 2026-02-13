
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ValueSpatialVariablePartialDerivativeDriver<>
// Generated on: pátek 13. února 2026 23:21:39
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ValueSpatialVariablePartialDerivativeDriver<>")]
public partial class ValueSpatialVariablePartialDerivativeDriver<T> : global::FrooxEngine.Component
	

{
    public global::FrooxEngine.IField<T> DriveX;
public global::FrooxEngine.IField<T> DriveY;
public global::FrooxEngine.IField<T> DriveZ;
public global::System.String VariableName;
public global::FrooxEngine.ValueSpatialVariableMode Mode;
public T DefaultValue;
public global::System.Single SamplingDistance;
public global::System.Boolean ComputeInLocalSpace;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("DriveX", new ResoniteLink.Reference() { });
members.Add("DriveY", new ResoniteLink.Reference() { });
members.Add("DriveZ", new ResoniteLink.Reference() { });
members.Add("VariableName", VariableName.ToResoniteLinkField());
members.Add("Mode", Mode.ToResoniteLinkField());
members.Add("DefaultValue", DefaultValue.ToResoniteLinkField());
members.Add("SamplingDistance", SamplingDistance.ToResoniteLinkField());
members.Add("ComputeInLocalSpace", ComputeInLocalSpace.ToResoniteLinkField());
}

}
}
