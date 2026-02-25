
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ButtonParentUnderUser
// Generated on: středa 25. února 2026 16:13:06
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ButtonParentUnderUser")]
public partial class ButtonParentUnderUser : global::FrooxEngine.Component, global::FrooxEngine.IButtonPressReceiver

{
    public global::FrooxEngine.Slot Root;
public global::System.Boolean FindObjectRoot;
public global::System.Boolean UnparentWhenParented;
public global::System.Boolean PreserveOriginalSpace;
public global::FrooxEngine.Slot _originalSpace;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Root", Root.ToResoniteReference(context));
members.Add("FindObjectRoot", FindObjectRoot.ToResoniteLinkField());
members.Add("UnparentWhenParented", UnparentWhenParented.ToResoniteLinkField());
members.Add("PreserveOriginalSpace", PreserveOriginalSpace.ToResoniteLinkField());
members.Add("_originalSpace", _originalSpace.ToResoniteReference(context));
}

}
}
