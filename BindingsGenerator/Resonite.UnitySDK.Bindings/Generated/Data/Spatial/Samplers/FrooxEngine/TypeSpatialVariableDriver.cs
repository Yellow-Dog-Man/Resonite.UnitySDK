
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TypeSpatialVariableDriver
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TypeSpatialVariableDriver")]
public partial class TypeSpatialVariableDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.SyncType Drive;
public global::System.String VariableName;
public System.String DefaultType;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Drive", Drive.ToResoniteReference(context));
members.Add("VariableName", VariableName.ToResoniteLinkField());
members.Add("DefaultType", DefaultType.ToResoniteLinkField());
}

}
}
