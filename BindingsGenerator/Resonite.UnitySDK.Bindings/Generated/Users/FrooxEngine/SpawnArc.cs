
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SpawnArc
// Generated on: čtvrtek 26. února 2026 15:09:16
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SpawnArc")]
public partial class SpawnArc : global::FrooxEngine.Component, global::FrooxEngine.IUserSpawnArea

{
    public global::System.Single Weight { get => Weight_Element.Data; set => Weight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Weight_Element = new();
public global::System.Int32 Capacity { get => Capacity_Element.Data; set => Capacity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Capacity_Element = new();
public global::System.Single Radius { get => Radius_Element.Data; set => Radius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Radius_Element = new();
public global::System.Single Arc { get => Arc_Element.Data; set => Arc_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Arc_Element = new();
public global::System.Int32 UsersPerArc { get => UsersPerArc_Element.Data; set => UsersPerArc_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> UsersPerArc_Element = new();
public global::System.Single CenterArcOffset { get => CenterArcOffset_Element.Data; set => CenterArcOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> CenterArcOffset_Element = new();
public global::System.Boolean GrowBothSides { get => GrowBothSides_Element.Data; set => GrowBothSides_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> GrowBothSides_Element = new();
public global::System.Single RowHeightOffset { get => RowHeightOffset_Element.Data; set => RowHeightOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RowHeightOffset_Element = new();
public global::System.Boolean OrientUser { get => OrientUser_Element.Data; set => OrientUser_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> OrientUser_Element = new();
public global::System.Boolean ParentUser { get => ParentUser_Element.Data; set => ParentUser_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ParentUser_Element = new();
public global::System.Boolean TiltUsers { get => TiltUsers_Element.Data; set => TiltUsers_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> TiltUsers_Element = new();
public global::FrooxEngine.UserRoot.UserNode PositionNode { get => PositionNode_Element.Data; set => PositionNode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.UserRoot.UserNode>, global::FrooxEngine.UserRoot.UserNode> PositionNode_Element = new();
public global::FrooxEngine.UserRoot.UserNode RotationNode { get => RotationNode_Element.Data; set => RotationNode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.UserRoot.UserNode>, global::FrooxEngine.UserRoot.UserNode> RotationNode_Element = new();
public global::System.Boolean _showTest { get => _showTest_Element.Data; set => _showTest_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _showTest_Element = new();
public global::System.Int32 _testSlots { get => _testSlots_Element.Data; set => _testSlots_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> _testSlots_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Weight", Weight_Element.ToLinkField(context));
members.Add("Capacity", Capacity_Element.ToLinkField(context));
members.Add("Radius", Radius_Element.ToLinkField(context));
members.Add("Arc", Arc_Element.ToLinkField(context));
members.Add("UsersPerArc", UsersPerArc_Element.ToLinkField(context));
members.Add("CenterArcOffset", CenterArcOffset_Element.ToLinkField(context));
members.Add("GrowBothSides", GrowBothSides_Element.ToLinkField(context));
members.Add("RowHeightOffset", RowHeightOffset_Element.ToLinkField(context));
members.Add("OrientUser", OrientUser_Element.ToLinkField(context));
members.Add("ParentUser", ParentUser_Element.ToLinkField(context));
members.Add("TiltUsers", TiltUsers_Element.ToLinkField(context));
members.Add("PositionNode", PositionNode_Element.ToLinkField(context));
members.Add("RotationNode", RotationNode_Element.ToLinkField(context));
members.Add("_showTest", _showTest_Element.ToLinkField(context));
members.Add("_testSlots", _testSlots_Element.ToLinkField(context));
}

}
}
