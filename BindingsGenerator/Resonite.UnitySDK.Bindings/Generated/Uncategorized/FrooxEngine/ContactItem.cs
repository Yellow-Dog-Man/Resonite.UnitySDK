
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ContactItem
// Generated on: čtvrtek 26. února 2026 10:04:44
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ContactItem")]
public partial class ContactItem : global::FrooxEngine.CircleThumbnailItem

{
    public global::FrooxEngine.UIX.Text _username { get => _username_Element.Data; set => _username_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _username_Element = new();
public global::FrooxEngine.UIX.Text _status { get => _status_Element.Data; set => _status_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _status_Element = new();
public global::FrooxEngine.UIX.Text _unreadCount { get => _unreadCount_Element.Data; set => _unreadCount_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _unreadCount_Element = new();
public global::FrooxEngine.UIX.Button _joinButton { get => _joinButton_Element.Data; set => _joinButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _joinButton_Element = new();
public global::System.String _rawUsername { get => _rawUsername_Element.Data; set => _rawUsername_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> _rawUsername_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncFieldList<global::System.String>, global::System.String, Field<global::FrooxEngine.Sync<global::System.String>, global::System.String>> _alternateNames = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_username", _username_Element.Data.ToResoniteReference(context));
members.Add("_status", _status_Element.Data.ToResoniteReference(context));
members.Add("_unreadCount", _unreadCount_Element.Data.ToResoniteReference(context));
members.Add("_joinButton", _joinButton_Element.Data.ToResoniteReference(context));
members.Add("_rawUsername", _rawUsername_Element.Data.ToResoniteLinkField());
members.Add("_alternateNames", new ResoniteLink.SyncList()
{
    Elements = _alternateNames.Data.ConvertList(m => m.Data.ToResoniteLinkField())
});
}

}
}
