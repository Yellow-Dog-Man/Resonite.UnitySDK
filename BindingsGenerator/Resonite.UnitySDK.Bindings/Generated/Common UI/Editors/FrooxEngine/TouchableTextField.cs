
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TouchableTextField
// Generated on: čtvrtek 26. února 2026 10:03:38
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TouchableTextField")]
public partial class TouchableTextField : global::FrooxEngine.Component, global::FrooxEngine.ITouchable

{
    public global::FrooxEngine.TextEditor TextEditor { get => TextEditor_Element.Data; set => TextEditor_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.TextEditor>, global::FrooxEngine.TextEditor> TextEditor_Element = new();
public global::System.Boolean AcceptOutOfSightTouch { get => AcceptOutOfSightTouch_Element.Data; set => AcceptOutOfSightTouch_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AcceptOutOfSightTouch_Element = new();
public global::System.Boolean AcceptPhysicalTouch { get => AcceptPhysicalTouch_Element.Data; set => AcceptPhysicalTouch_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AcceptPhysicalTouch_Element = new();
public global::System.Boolean AcceptRemoteTouch { get => AcceptRemoteTouch_Element.Data; set => AcceptRemoteTouch_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AcceptRemoteTouch_Element = new();
public global::System.Boolean EditModeOnly { get => EditModeOnly_Element.Data; set => EditModeOnly_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> EditModeOnly_Element = new();
public global::System.Boolean ActiveUserRootOnly { get => ActiveUserRootOnly_Element.Data; set => ActiveUserRootOnly_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ActiveUserRootOnly_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TextEditor", TextEditor_Element.Data.ToResoniteReference(context));
members.Add("AcceptOutOfSightTouch", AcceptOutOfSightTouch_Element.Data.ToResoniteLinkField());
members.Add("AcceptPhysicalTouch", AcceptPhysicalTouch_Element.Data.ToResoniteLinkField());
members.Add("AcceptRemoteTouch", AcceptRemoteTouch_Element.Data.ToResoniteLinkField());
members.Add("EditModeOnly", EditModeOnly_Element.Data.ToResoniteLinkField());
members.Add("ActiveUserRootOnly", ActiveUserRootOnly_Element.Data.ToResoniteLinkField());
}

}
}
