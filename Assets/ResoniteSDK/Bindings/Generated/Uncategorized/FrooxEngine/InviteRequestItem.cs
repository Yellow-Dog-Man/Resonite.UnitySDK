
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InviteRequestItem
// Generated on: sobota 14. února 2026 8:58:45
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InviteRequestItem")]
public partial class InviteRequestItem : global::FrooxEngine.Component

{
    public global::FrooxEngine.ContactsDialog ContactDialog;
public global::FrooxEngine.UIX.Text HeaderText;
public global::FrooxEngine.UIX.Button InviteButton;
public global::FrooxEngine.UIX.Button AddContactButton;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ContactDialog", ContactDialog.ToResoniteReference(context));
members.Add("HeaderText", HeaderText.ToResoniteReference(context));
members.Add("InviteButton", InviteButton.ToResoniteReference(context));
members.Add("AddContactButton", AddContactButton.ToResoniteReference(context));
}

}
}
