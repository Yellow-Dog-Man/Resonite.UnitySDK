
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DesktopDisplayLayout
// Generated on: pátek 6. března 2026 14:18:08
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DesktopDisplayLayout")]
public partial class DesktopDisplayLayout : global::FrooxEngine.Component

{
    public global::FrooxEngine.UserRef User = new();
public global::FrooxEngine.Slot DisplayTemplate { get => DisplayTemplate_Element.Data; set => DisplayTemplate_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> DisplayTemplate_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("User", User.ToLinkSyncObject(context));
members.Add("DisplayTemplate", DisplayTemplate_Element.ToLinkReference(context));
}

}
}
