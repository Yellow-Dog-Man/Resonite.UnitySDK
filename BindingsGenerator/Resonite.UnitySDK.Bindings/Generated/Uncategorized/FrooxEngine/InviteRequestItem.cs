
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InviteRequestItem
// Generated on: čtvrtek 26. února 2026 10:04:46
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InviteRequestItem")]
public partial class InviteRequestItem : global::FrooxEngine.Component

{
    public global::FrooxEngine.ContactsDialog ContactDialog { get => ContactDialog_Element.Data; set => ContactDialog_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ContactsDialog>, global::FrooxEngine.ContactsDialog> ContactDialog_Element = new();
public global::FrooxEngine.UIX.Text HeaderText { get => HeaderText_Element.Data; set => HeaderText_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> HeaderText_Element = new();
public global::FrooxEngine.UIX.Button InviteButton { get => InviteButton_Element.Data; set => InviteButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> InviteButton_Element = new();
public global::FrooxEngine.UIX.Button AddContactButton { get => AddContactButton_Element.Data; set => AddContactButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> AddContactButton_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ContactDialog", ContactDialog_Element.Data.ToResoniteReference(context));
members.Add("HeaderText", HeaderText_Element.Data.ToResoniteReference(context));
members.Add("InviteButton", InviteButton_Element.Data.ToResoniteReference(context));
members.Add("AddContactButton", AddContactButton_Element.Data.ToResoniteReference(context));
}

}
}
