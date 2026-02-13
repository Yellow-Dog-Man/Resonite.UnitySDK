
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InviteRequestItem
// Generated on: pátek 13. února 2026 5:52:33
// Resonite version: 2026.2.13.254
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ContactDialog", new ResoniteLink.Reference() { });
members.Add("HeaderText", new ResoniteLink.Reference() { });
members.Add("InviteButton", new ResoniteLink.Reference() { });
members.Add("AddContactButton", new ResoniteLink.Reference() { });
}

}
}
