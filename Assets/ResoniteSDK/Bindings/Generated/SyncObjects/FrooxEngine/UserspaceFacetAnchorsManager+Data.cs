
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserspaceFacetAnchorsManager+Data
// Generated on: pátek 13. února 2026 23:23:18
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
    public partial class UserspaceFacetAnchorsManager
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UserspaceFacetAnchorsManager+Data")]
public partial class Data : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.FacetAnchorPoint Point;
public global::FrooxEngine.Slot Root;
public global::FrooxEngine.Workspace Workspace;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Point", Point.ToResoniteLinkField());
members.Add("Root", new ResoniteLink.Reference() { });
members.Add("Workspace", new ResoniteLink.Reference() { });
}

}
            }
}
