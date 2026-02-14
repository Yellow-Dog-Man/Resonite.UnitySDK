
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Snapper
// Generated on: sobota 14. února 2026 8:58:40
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Snapper")]
public partial class Snapper : global::FrooxEngine.Component, global::FrooxEngine.IGrabEventReceiver

{
    public global::System.Boolean UseBoundingBoxCenter;
public global::System.Single SnapCheckRadius;
public global::System.Boolean CheckStaticColliders;
public System.Collections.Generic.List<global::FrooxEngine.SnapTarget> SnapTargetWhitelist;
public System.Collections.Generic.List<global::System.String> Keywords;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UseBoundingBoxCenter", UseBoundingBoxCenter.ToResoniteLinkField());
members.Add("SnapCheckRadius", SnapCheckRadius.ToResoniteLinkField());
members.Add("CheckStaticColliders", CheckStaticColliders.ToResoniteLinkField());
members.Add("SnapTargetWhitelist", new ResoniteLink.SyncList()
{
    Elements = SnapTargetWhitelist.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("Keywords", new ResoniteLink.SyncList()
{
    Elements = Keywords.ConvertList(m => m.ToResoniteLinkField())
});
}

}
}
