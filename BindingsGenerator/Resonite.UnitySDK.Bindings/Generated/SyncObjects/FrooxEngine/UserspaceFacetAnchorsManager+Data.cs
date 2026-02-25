
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserspaceFacetAnchorsManager+Data
// Generated on: středa 25. února 2026 16:14:44
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
    public partial class UserspaceFacetAnchorsManager
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UserspaceFacetAnchorsManager+Data")]
public partial class Data : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.FacetAnchorPoint Point;
public global::FrooxEngine.Slot Root;
public global::FrooxEngine.Workspace Workspace;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Point", Point.ToResoniteLinkField());
members.Add("Root", Root.ToResoniteReference(context));
members.Add("Workspace", Workspace.ToResoniteReference(context));
}

}
            }
}
