
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ContactLink
// Generated on: čtvrtek 26. února 2026 12:26:52
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ContactLink")]
public partial class ContactLink : global::FrooxEngine.Component, global::FrooxEngine.ITouchable, global::FrooxEngine.IButtonPressReceiver

{
    public global::System.String UserId { get => UserId_Element.Data; set => UserId_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> UserId_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UserId", UserId_Element.ToLinkField(context));
}

}
}
