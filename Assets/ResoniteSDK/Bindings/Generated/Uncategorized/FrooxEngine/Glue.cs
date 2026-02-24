
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Glue
// Generated on: úterý 24. února 2026 18:20:11
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Glue")]
public partial class Glue : global::FrooxEngine.Component

{
    public global::FrooxEngine.Glue.Mode GlueMode;
public global::System.Boolean Active;
public global::System.Single DryTime;
public global::System.Double Expire;
public global::FrooxEngine.User GluingUser;
public global::System.Boolean _forceDry;
public global::System.Boolean isDrying;
public global::System.Double dryStartTime;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("GlueMode", GlueMode.ToResoniteLinkField());
members.Add("Active", Active.ToResoniteLinkField());
members.Add("DryTime", DryTime.ToResoniteLinkField());
members.Add("Expire", Expire.ToResoniteLinkField());
members.Add("GluingUser", GluingUser.ToResoniteReference(context));
members.Add("_forceDry", _forceDry.ToResoniteLinkField());
members.Add("isDrying", isDrying.ToResoniteLinkField());
members.Add("dryStartTime", dryStartTime.ToResoniteLinkField());
}

}
}
