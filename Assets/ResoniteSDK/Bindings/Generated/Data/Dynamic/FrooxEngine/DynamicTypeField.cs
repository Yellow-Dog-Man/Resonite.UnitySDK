
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DynamicTypeField
// Generated on: sobota 14. února 2026 8:57:04
// Resonite version: 2026.2.14.493
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
