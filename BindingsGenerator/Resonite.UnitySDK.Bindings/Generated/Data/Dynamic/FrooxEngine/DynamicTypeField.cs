
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DynamicTypeField
// Generated on: středa 25. února 2026 16:13:07
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DynamicTypeField")]
public partial class DynamicTypeField : global::FrooxEngine.DynamicVariableBase<System.String>

{
    public global::FrooxEngine.SyncType TargetField;
public global::System.Boolean OverrideOnLink;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetField", TargetField.ToResoniteReference(context));
members.Add("OverrideOnLink", OverrideOnLink.ToResoniteLinkField());
}

}
}
