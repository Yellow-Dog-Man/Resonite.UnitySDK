
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserDistanceValueDriver<>
// Generated on: čtvrtek 26. února 2026 15:09:08
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UserDistanceValueDriver<>")]
public partial class UserDistanceValueDriver<T> : global::FrooxEngine.Component
	

{
    public global::FrooxEngine.UserRoot.UserNode Node { get => Node_Element.Data; set => Node_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.UserRoot.UserNode>, global::FrooxEngine.UserRoot.UserNode> Node_Element = new();
public global::System.Single Distance { get => Distance_Element.Data; set => Distance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Distance_Element = new();
public global::FrooxEngine.IField<T> TargetField { get => TargetField_Element.Data; set => TargetField_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<T>, global::FrooxEngine.IField<T>> TargetField_Element = new();
public T NearValue { get => NearValue_Element.Data; set => NearValue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> NearValue_Element = new();
public T FarValue { get => FarValue_Element.Data; set => FarValue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<T>, T> FarValue_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Node", Node_Element.ToLinkField(context));
members.Add("Distance", Distance_Element.ToLinkField(context));
members.Add("TargetField", TargetField_Element.ToLinkReference(context));
members.Add("NearValue", NearValue_Element.ToLinkField(context));
members.Add("FarValue", FarValue_Element.ToLinkField(context));
}

}
}
