
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TypeSpatialVariableDriver
// Generated on: pátek 13. února 2026 5:51:12
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TypeSpatialVariableDriver")]
public partial class TypeSpatialVariableDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.SyncType Drive;
public global::System.String VariableName;
public System.String DefaultType;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Drive", new ResoniteLink.Reference() { });
members.Add("VariableName", VariableName.ToResoniteLinkField());
members.Add("DefaultType", DefaultType.ToResoniteLinkField());
}

}
}
