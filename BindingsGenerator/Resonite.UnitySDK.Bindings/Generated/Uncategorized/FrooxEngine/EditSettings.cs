
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.EditSettings
// Generated on: středa 25. února 2026 16:14:37
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
