
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Snapper
// Generated on: čtvrtek 26. února 2026 10:04:42
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Snapper")]
public partial class Snapper : global::FrooxEngine.Component, global::FrooxEngine.IGrabEventReceiver

{
    public global::System.Boolean UseBoundingBoxCenter { get => UseBoundingBoxCenter_Element.Data; set => UseBoundingBoxCenter_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseBoundingBoxCenter_Element = new();
public global::System.Single SnapCheckRadius { get => SnapCheckRadius_Element.Data; set => SnapCheckRadius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SnapCheckRadius_Element = new();
public global::System.Boolean CheckStaticColliders { get => CheckStaticColliders_Element.Data; set => CheckStaticColliders_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> CheckStaticColliders_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.SnapTarget>, global::FrooxEngine.SnapTarget, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.SnapTarget>, global::FrooxEngine.SnapTarget>> SnapTargetWhitelist = new();
public global::SyncFieldList<global::FrooxEngine.SyncFieldList<global::System.String>, global::System.String, Field<global::FrooxEngine.Sync<global::System.String>, global::System.String>> Keywords = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UseBoundingBoxCenter", UseBoundingBoxCenter_Element.Data.ToResoniteLinkField());
members.Add("SnapCheckRadius", SnapCheckRadius_Element.Data.ToResoniteLinkField());
members.Add("CheckStaticColliders", CheckStaticColliders_Element.Data.ToResoniteLinkField());
members.Add("SnapTargetWhitelist", new ResoniteLink.SyncList()
{
    Elements = SnapTargetWhitelist.Data.ConvertList(m => m.Data.ToResoniteReference(context))
});
members.Add("Keywords", new ResoniteLink.SyncList()
{
    Elements = Keywords.Data.ConvertList(m => m.Data.ToResoniteLinkField())
});
}

}
}
