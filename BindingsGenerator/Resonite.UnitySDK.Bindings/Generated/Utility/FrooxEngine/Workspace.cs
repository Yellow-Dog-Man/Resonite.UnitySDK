
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Workspace
// Generated on: středa 25. února 2026 16:14:42
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Workspace")]
public partial class Workspace : global::FrooxEngine.Component, global::FrooxEngine.ICustomInspector, global::FrooxEngine.IModifiedEventReceiver

{
    public global::FrooxEngine.UserRef User;
public global::System.String OverrideOwnerId;
public global::System.String WorkspacePath;
public global::System.Boolean ReadOnly;
public global::System.Single AutosaveDelay;
public global::System.Boolean SuspendUpdates;
public global::System.Boolean _unsavedChanges;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("User", new ResoniteLink.SyncObject() { Members = User.CollectMembers(context) });
members.Add("OverrideOwnerId", OverrideOwnerId.ToResoniteLinkField());
members.Add("WorkspacePath", WorkspacePath.ToResoniteLinkField());
members.Add("ReadOnly", ReadOnly.ToResoniteLinkField());
members.Add("AutosaveDelay", AutosaveDelay.ToResoniteLinkField());
members.Add("SuspendUpdates", SuspendUpdates.ToResoniteLinkField());
members.Add("_unsavedChanges", _unsavedChanges.ToResoniteLinkField());
}

}
}
