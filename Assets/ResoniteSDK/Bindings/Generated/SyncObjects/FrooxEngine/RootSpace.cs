
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RootSpace
// Generated on: pátek 13. února 2026 23:21:41
// Resonite version: 2026.2.12.359
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("LocalSpace", new ResoniteLink.Reference() { });
members.Add("UseParentSpace", UseParentSpace.ToResoniteLinkField());
members.Add("Default", Default.ToResoniteLinkField());
members.Add("OverrideRootSpace", new ResoniteLink.Reference() { });
}

}
}
