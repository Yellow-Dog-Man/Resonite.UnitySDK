
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonSpawnArea
// Generated on: úterý 24. února 2026 18:20:30
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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
    public global::FrooxEngine.IPointGenerator SpawnPointGenerator;
public UnityEngine.Vector3 FloorPointRay;
public global::System.Single OtherUserCheckRadius;
public global::System.Boolean ParentUser;
public global::System.Boolean OrientUser;
public global::System.Boolean ScaleUser;
public global::System.Int32 Capacity;
public global::System.Single BaseWeight;
public global::FrooxEngine.UserRoot.UserNode PositionNode;
public global::FrooxEngine.UserRoot.UserNode RotationNode;
public global::FrooxEngine.Slot ParentOverride;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SpawnPointGenerator", SpawnPointGenerator.ToResoniteReference(context));
members.Add("FloorPointRay", FloorPointRay.ToResoniteLinkField());
members.Add("OtherUserCheckRadius", OtherUserCheckRadius.ToResoniteLinkField());
members.Add("ParentUser", ParentUser.ToResoniteLinkField());
members.Add("OrientUser", OrientUser.ToResoniteLinkField());
members.Add("ScaleUser", ScaleUser.ToResoniteLinkField());
members.Add("Capacity", Capacity.ToResoniteLinkField());
members.Add("BaseWeight", BaseWeight.ToResoniteLinkField());
members.Add("PositionNode", PositionNode.ToResoniteLinkField());
members.Add("RotationNode", RotationNode.ToResoniteLinkField());
members.Add("ParentOverride", ParentOverride.ToResoniteReference(context));
}

}
}
