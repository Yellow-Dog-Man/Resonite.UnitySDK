
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Hyperlink
// Generated on: čtvrtek 26. února 2026 10:04:50
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Hyperlink")]
public partial class Hyperlink : global::FrooxEngine.Component, global::FrooxEngine.ITouchable, global::FrooxEngine.IButtonPressReceiver

{
    public System.Uri URL { get => URL_Element.Data; set => URL_Element.Data = value; }
public Field<global::FrooxEngine.Sync<System.Uri>, System.Uri> URL_Element = new();
public global::System.Boolean OpenOnce { get => OpenOnce_Element.Data; set => OpenOnce_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> OpenOnce_Element = new();
public global::System.String Reason { get => Reason_Element.Data; set => Reason_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> Reason_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("URL", URL_Element.Data.ToResoniteLinkField());
members.Add("OpenOnce", OpenOnce_Element.Data.ToResoniteLinkField());
members.Add("Reason", Reason_Element.Data.ToResoniteLinkField());
}

}
}
