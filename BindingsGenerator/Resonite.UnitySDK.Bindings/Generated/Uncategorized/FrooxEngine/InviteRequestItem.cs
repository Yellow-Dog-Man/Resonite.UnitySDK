
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InviteRequestItem
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InviteRequestItem")]
public partial class InviteRequestItem : global::FrooxEngine.Component

{
    public global::FrooxEngine.ContactsDialog ContactDialog { get => ContactDialog_Element.Data; set => ContactDialog_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ContactsDialog>, global::FrooxEngine.ContactsDialog> ContactDialog_Element = new();
public global::FrooxEngine.UIX.Text HeaderText { get => HeaderText_Element.Data; set => HeaderText_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> HeaderText_Element = new();
public global::FrooxEngine.UIX.Button InviteButton { get => InviteButton_Element.Data; set => InviteButton_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> InviteButton_Element = new();
public global::FrooxEngine.UIX.Button AddContactButton { get => AddContactButton_Element.Data; set => AddContactButton_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> AddContactButton_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ContactDialog", ContactDialog_Element.ToLinkReference(context));
members.Add("HeaderText", HeaderText_Element.ToLinkReference(context));
members.Add("InviteButton", InviteButton_Element.ToLinkReference(context));
members.Add("AddContactButton", AddContactButton_Element.ToLinkReference(context));
}

}
}
