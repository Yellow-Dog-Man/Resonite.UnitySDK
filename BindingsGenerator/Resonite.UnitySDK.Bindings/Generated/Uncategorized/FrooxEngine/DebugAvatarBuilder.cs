
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DebugAvatarBuilder
// Generated on: středa 25. února 2026 16:14:36
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DebugAvatarBuilder")]
public partial class DebugAvatarBuilder : global::FrooxEngine.Component

{
    public global::System.Boolean SetupServerVoice;
public global::System.Boolean SetupClientVoice;
public global::System.Boolean SetupServerTools;
public global::System.Boolean SetupClientTools;
public global::System.Boolean ParentClientsToServer;
public global::System.Boolean AlignTracking;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SetupServerVoice", SetupServerVoice.ToResoniteLinkField());
members.Add("SetupClientVoice", SetupClientVoice.ToResoniteLinkField());
members.Add("SetupServerTools", SetupServerTools.ToResoniteLinkField());
members.Add("SetupClientTools", SetupClientTools.ToResoniteLinkField());
members.Add("ParentClientsToServer", ParentClientsToServer.ToResoniteLinkField());
members.Add("AlignTracking", AlignTracking.ToResoniteLinkField());
}

}
}
