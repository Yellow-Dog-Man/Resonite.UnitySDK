
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Grabber
// Generated on: čtvrtek 26. února 2026 10:03:39
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Grabber")]
public partial class Grabber : global::FrooxEngine.UserRootComponent

{
    public global::FrooxEngine.User AutoUpdateUser { get => AutoUpdateUser_Element.Data; set => AutoUpdateUser_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.User>, global::FrooxEngine.User> AutoUpdateUser_Element = new();
public global::System.Single ReleaseCheckRadius { get => ReleaseCheckRadius_Element.Data; set => ReleaseCheckRadius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ReleaseCheckRadius_Element = new();
public global::Renderite.Shared.BodyNode CorrespondingBodyNode { get => CorrespondingBodyNode_Element.Data; set => CorrespondingBodyNode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.BodyNode>, global::Renderite.Shared.BodyNode> CorrespondingBodyNode_Element = new();
public global::FrooxEngine.Grabber _scaleReference { get => _scaleReference_Element.Data; set => _scaleReference_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Grabber>, global::FrooxEngine.Grabber> _scaleReference_Element = new();
public UnityEngine.Vector3 _baseScale { get => _baseScale_Element.Data; set => _baseScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> _baseScale_Element = new();
public global::System.Single _baseDistance { get => _baseDistance_Element.Data; set => _baseDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> _baseDistance_Element = new();
public global::FrooxEngine.Slot _holderSlot { get => _holderSlot_Element.Data; set => _holderSlot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _holderSlot_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AutoUpdateUser", AutoUpdateUser_Element.Data.ToResoniteReference(context));
members.Add("ReleaseCheckRadius", ReleaseCheckRadius_Element.Data.ToResoniteLinkField());
members.Add("CorrespondingBodyNode", CorrespondingBodyNode_Element.Data.ToResoniteLinkField());
members.Add("_scaleReference", _scaleReference_Element.Data.ToResoniteReference(context));
members.Add("_baseScale", _baseScale_Element.Data.ToResoniteLinkField());
members.Add("_baseDistance", _baseDistance_Element.Data.ToResoniteLinkField());
members.Add("_holderSlot", _holderSlot_Element.Data.ToResoniteReference(context));
}

}
}
