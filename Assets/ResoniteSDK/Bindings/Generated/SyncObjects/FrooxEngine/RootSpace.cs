
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RootSpace
// Generated on: sobota 14. února 2026 8:57:07
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RootSpace")]
public partial class RootSpace : global::FrooxEngine.SyncObject, global::FrooxEngine.ICustomInspector

{
    public global::FrooxEngine.Slot LocalSpace;
public global::System.Boolean UseParentSpace;
public global::FrooxEngine.RootSpace.DefaultSpace Default;
public global::FrooxEngine.RootSpace OverrideRootSpace;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LocalSpace", LocalSpace.ToResoniteReference(context));
members.Add("UseParentSpace", UseParentSpace.ToResoniteLinkField());
members.Add("Default", Default.ToResoniteLinkField());
members.Add("OverrideRootSpace", OverrideRootSpace.ToResoniteReference(context));
}

}
}
