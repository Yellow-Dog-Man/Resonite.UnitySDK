
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DebugAvatarBuilder
// Generated on: čtvrtek 26. února 2026 12:28:10
// Resonite version: 2026.2.26.702
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
    public global::System.Boolean SetupServerVoice { get => SetupServerVoice_Element.Data; set => SetupServerVoice_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SetupServerVoice_Element = new();
public global::System.Boolean SetupClientVoice { get => SetupClientVoice_Element.Data; set => SetupClientVoice_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SetupClientVoice_Element = new();
public global::System.Boolean SetupServerTools { get => SetupServerTools_Element.Data; set => SetupServerTools_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SetupServerTools_Element = new();
public global::System.Boolean SetupClientTools { get => SetupClientTools_Element.Data; set => SetupClientTools_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SetupClientTools_Element = new();
public global::System.Boolean ParentClientsToServer { get => ParentClientsToServer_Element.Data; set => ParentClientsToServer_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ParentClientsToServer_Element = new();
public global::System.Boolean AlignTracking { get => AlignTracking_Element.Data; set => AlignTracking_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AlignTracking_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SetupServerVoice", SetupServerVoice_Element.ToLinkField(context));
members.Add("SetupClientVoice", SetupClientVoice_Element.ToLinkField(context));
members.Add("SetupServerTools", SetupServerTools_Element.ToLinkField(context));
members.Add("SetupClientTools", SetupClientTools_Element.ToLinkField(context));
members.Add("ParentClientsToServer", ParentClientsToServer_Element.ToLinkField(context));
members.Add("AlignTracking", AlignTracking_Element.ToLinkField(context));
}

}
}
