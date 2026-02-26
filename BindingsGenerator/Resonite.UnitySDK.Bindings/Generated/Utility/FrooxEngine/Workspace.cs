
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Workspace
// Generated on: čtvrtek 26. února 2026 12:28:12
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Workspace")]
public partial class Workspace : global::FrooxEngine.Component, global::FrooxEngine.ICustomInspector, global::FrooxEngine.IModifiedEventReceiver

{
    public global::FrooxEngine.UserRef User = new();
public global::System.String OverrideOwnerId { get => OverrideOwnerId_Element.Data; set => OverrideOwnerId_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> OverrideOwnerId_Element = new();
public global::System.String WorkspacePath { get => WorkspacePath_Element.Data; set => WorkspacePath_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> WorkspacePath_Element = new();
public global::System.Boolean ReadOnly { get => ReadOnly_Element.Data; set => ReadOnly_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ReadOnly_Element = new();
public global::System.Single AutosaveDelay { get => AutosaveDelay_Element.Data; set => AutosaveDelay_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AutosaveDelay_Element = new();
public global::System.Boolean SuspendUpdates { get => SuspendUpdates_Element.Data; set => SuspendUpdates_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> SuspendUpdates_Element = new();
public global::System.Boolean _unsavedChanges { get => _unsavedChanges_Element.Data; set => _unsavedChanges_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _unsavedChanges_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("User", User.ToLinkSyncObject(context));
members.Add("OverrideOwnerId", OverrideOwnerId_Element.ToLinkField(context));
members.Add("WorkspacePath", WorkspacePath_Element.ToLinkField(context));
members.Add("ReadOnly", ReadOnly_Element.ToLinkField(context));
members.Add("AutosaveDelay", AutosaveDelay_Element.ToLinkField(context));
members.Add("SuspendUpdates", SuspendUpdates_Element.ToLinkField(context));
members.Add("_unsavedChanges", _unsavedChanges_Element.ToLinkField(context));
}

}
}
