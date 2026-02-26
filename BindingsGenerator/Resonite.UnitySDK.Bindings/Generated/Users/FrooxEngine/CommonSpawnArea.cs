
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonSpawnArea
// Generated on: čtvrtek 26. února 2026 12:28:14
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonSpawnArea")]
public partial class CommonSpawnArea : global::FrooxEngine.Component, global::FrooxEngine.IUserSpawnArea

{
    public global::FrooxEngine.IPointGenerator SpawnPointGenerator { get => SpawnPointGenerator_Element.Data; set => SpawnPointGenerator_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IPointGenerator>, global::FrooxEngine.IPointGenerator> SpawnPointGenerator_Element = new();
public UnityEngine.Vector3 FloorPointRay { get => FloorPointRay_Element.Data; set => FloorPointRay_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> FloorPointRay_Element = new();
public global::System.Single OtherUserCheckRadius { get => OtherUserCheckRadius_Element.Data; set => OtherUserCheckRadius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> OtherUserCheckRadius_Element = new();
public global::System.Boolean ParentUser { get => ParentUser_Element.Data; set => ParentUser_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ParentUser_Element = new();
public global::System.Boolean OrientUser { get => OrientUser_Element.Data; set => OrientUser_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> OrientUser_Element = new();
public global::System.Boolean ScaleUser { get => ScaleUser_Element.Data; set => ScaleUser_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ScaleUser_Element = new();
public global::System.Int32 Capacity { get => Capacity_Element.Data; set => Capacity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Capacity_Element = new();
public global::System.Single BaseWeight { get => BaseWeight_Element.Data; set => BaseWeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> BaseWeight_Element = new();
public global::FrooxEngine.UserRoot.UserNode PositionNode { get => PositionNode_Element.Data; set => PositionNode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.UserRoot.UserNode>, global::FrooxEngine.UserRoot.UserNode> PositionNode_Element = new();
public global::FrooxEngine.UserRoot.UserNode RotationNode { get => RotationNode_Element.Data; set => RotationNode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.UserRoot.UserNode>, global::FrooxEngine.UserRoot.UserNode> RotationNode_Element = new();
public global::FrooxEngine.Slot ParentOverride { get => ParentOverride_Element.Data; set => ParentOverride_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> ParentOverride_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SpawnPointGenerator", SpawnPointGenerator_Element.ToLinkReference(context));
members.Add("FloorPointRay", FloorPointRay_Element.ToLinkField(context));
members.Add("OtherUserCheckRadius", OtherUserCheckRadius_Element.ToLinkField(context));
members.Add("ParentUser", ParentUser_Element.ToLinkField(context));
members.Add("OrientUser", OrientUser_Element.ToLinkField(context));
members.Add("ScaleUser", ScaleUser_Element.ToLinkField(context));
members.Add("Capacity", Capacity_Element.ToLinkField(context));
members.Add("BaseWeight", BaseWeight_Element.ToLinkField(context));
members.Add("PositionNode", PositionNode_Element.ToLinkField(context));
members.Add("RotationNode", RotationNode_Element.ToLinkField(context));
members.Add("ParentOverride", ParentOverride_Element.ToLinkReference(context));
}

}
}
