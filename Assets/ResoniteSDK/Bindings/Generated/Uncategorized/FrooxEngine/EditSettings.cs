
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.EditSettings
// Generated on: sobota 14. února 2026 8:58:42
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.EditSettings")]
public partial class EditSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.EditSettings>

{
    public global::System.Boolean ConfirmComponentDestroy;
public global::System.Boolean ConfirmSlotDestroy;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ConfirmComponentDestroy", ConfirmComponentDestroy.ToResoniteLinkField());
members.Add("ConfirmSlotDestroy", ConfirmSlotDestroy.ToResoniteLinkField());
}

}
}
