
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Workspace
// Generated on: pátek 13. února 2026 5:52:35
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("User", new ResoniteLink.SyncObject() { Members = User.CollectMembers() });
members.Add("OverrideOwnerId", OverrideOwnerId.ToResoniteLinkField());
members.Add("WorkspacePath", WorkspacePath.ToResoniteLinkField());
members.Add("ReadOnly", ReadOnly.ToResoniteLinkField());
members.Add("AutosaveDelay", AutosaveDelay.ToResoniteLinkField());
members.Add("SuspendUpdates", SuspendUpdates.ToResoniteLinkField());
members.Add("_unsavedChanges", _unsavedChanges.ToResoniteLinkField());
}

}
}
