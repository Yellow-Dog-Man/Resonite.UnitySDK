
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.EditSettings
// Generated on: čtvrtek 26. února 2026 12:28:10
// Resonite version: 2026.2.26.702
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
    public global::System.Boolean ConfirmComponentDestroy { get => ConfirmComponentDestroy_Element.Data; set => ConfirmComponentDestroy_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ConfirmComponentDestroy_Element = new();
public global::System.Boolean ConfirmSlotDestroy { get => ConfirmSlotDestroy_Element.Data; set => ConfirmSlotDestroy_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ConfirmSlotDestroy_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ConfirmComponentDestroy", ConfirmComponentDestroy_Element.ToLinkField(context));
members.Add("ConfirmSlotDestroy", ConfirmSlotDestroy_Element.ToLinkField(context));
}

}
}
