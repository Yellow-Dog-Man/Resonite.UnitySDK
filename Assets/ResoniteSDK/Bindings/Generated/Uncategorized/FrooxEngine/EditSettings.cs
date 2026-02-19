
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.EditSettings
// Generated on: čtvrtek 19. února 2026 8:00:27
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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
