
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InspectorMemberActions
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InspectorMemberActions")]
public partial class InspectorMemberActions : global::FrooxEngine.Component, global::FrooxEngine.IButtonPressReceiver

{
    public global::FrooxEngine.ISyncMember Member { get => Member_Element.Data; set => Member_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ISyncMember>, global::FrooxEngine.ISyncMember> Member_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Member", Member_Element.ToLinkReference(context));
}

}
}
