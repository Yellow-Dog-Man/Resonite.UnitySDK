
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InspectorMemberActions
// Generated on: pondělí 2. března 2026 17:53:34
// Resonite version: 2026.3.2.1000
// Resonite Link Version: 1.0.0.0
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
