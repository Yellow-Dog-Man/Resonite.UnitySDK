
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SettingManager
// Generated on: sobota 14. února 2026 8:58:47
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SettingManager")]
public partial class SettingManager : global::FrooxEngine.Component

{
    public global::System.String OwnerId;
public global::FrooxEngine.SettingManager SupressedBy;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OwnerId", OwnerId.ToResoniteLinkField());
members.Add("SupressedBy", SupressedBy.ToResoniteReference(context));
}

}
}
