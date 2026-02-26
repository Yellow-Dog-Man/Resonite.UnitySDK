
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.KeyboardLookSettings
// Generated on: čtvrtek 26. února 2026 15:09:12
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.KeyboardLookSettings")]
public partial class KeyboardLookSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.KeyboardLookSettings>

{
    public global::System.Boolean LookEnabled { get => LookEnabled_Element.Data; set => LookEnabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> LookEnabled_Element = new();
public global::System.Single HorizontalSpeed { get => HorizontalSpeed_Element.Data; set => HorizontalSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HorizontalSpeed_Element = new();
public global::System.Single VerticalSpeed { get => VerticalSpeed_Element.Data; set => VerticalSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> VerticalSpeed_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LookEnabled", LookEnabled_Element.ToLinkField(context));
members.Add("HorizontalSpeed", HorizontalSpeed_Element.ToLinkField(context));
members.Add("VerticalSpeed", VerticalSpeed_Element.ToLinkField(context));
}

}
}
