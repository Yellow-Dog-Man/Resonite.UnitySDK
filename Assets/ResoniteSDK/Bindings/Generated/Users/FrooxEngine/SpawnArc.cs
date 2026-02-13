
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SpawnArc
// Generated on: pátek 13. února 2026 23:23:19
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SpawnArc")]
public partial class SpawnArc : global::FrooxEngine.Component, global::FrooxEngine.IUserSpawnArea

{
    public global::System.Single Weight;
public global::System.Int32 Capacity;
public global::System.Single Radius;
public global::System.Single Arc;
public global::System.Int32 UsersPerArc;
public global::System.Single CenterArcOffset;
public global::System.Boolean GrowBothSides;
public global::System.Single RowHeightOffset;
public global::System.Boolean OrientUser;
public global::System.Boolean ParentUser;
public global::System.Boolean TiltUsers;
public global::FrooxEngine.UserRoot.UserNode PositionNode;
public global::FrooxEngine.UserRoot.UserNode RotationNode;
public global::System.Boolean _showTest;
public global::System.Int32 _testSlots;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Weight", Weight.ToResoniteLinkField());
members.Add("Capacity", Capacity.ToResoniteLinkField());
members.Add("Radius", Radius.ToResoniteLinkField());
members.Add("Arc", Arc.ToResoniteLinkField());
members.Add("UsersPerArc", UsersPerArc.ToResoniteLinkField());
members.Add("CenterArcOffset", CenterArcOffset.ToResoniteLinkField());
members.Add("GrowBothSides", GrowBothSides.ToResoniteLinkField());
members.Add("RowHeightOffset", RowHeightOffset.ToResoniteLinkField());
members.Add("OrientUser", OrientUser.ToResoniteLinkField());
members.Add("ParentUser", ParentUser.ToResoniteLinkField());
members.Add("TiltUsers", TiltUsers.ToResoniteLinkField());
members.Add("PositionNode", PositionNode.ToResoniteLinkField());
members.Add("RotationNode", RotationNode.ToResoniteLinkField());
members.Add("_showTest", _showTest.ToResoniteLinkField());
members.Add("_testSlots", _testSlots.ToResoniteLinkField());
}

}
}
