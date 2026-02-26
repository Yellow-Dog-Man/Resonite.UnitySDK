
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserspaceFacetAnchorsManager+Data
// Generated on: čtvrtek 26. února 2026 15:09:15
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.FacetAnchorPoint Point { get => Point_Element.Data; set => Point_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.FacetAnchorPoint>, global::FrooxEngine.FacetAnchorPoint> Point_Element = new();
public global::FrooxEngine.Slot Root { get => Root_Element.Data; set => Root_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> Root_Element = new();
public global::FrooxEngine.Workspace Workspace { get => Workspace_Element.Data; set => Workspace_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Workspace>, global::FrooxEngine.Workspace> Workspace_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Point", Point_Element.ToLinkField(context));
members.Add("Root", Root_Element.ToLinkReference(context));
members.Add("Workspace", Workspace_Element.ToLinkReference(context));
}

}
            }
}
