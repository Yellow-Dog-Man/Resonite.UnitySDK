
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Glue
// Generated on: čtvrtek 26. února 2026 12:28:05
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Glue")]
public partial class Glue : global::FrooxEngine.Component

{
    public global::FrooxEngine.Glue.Mode GlueMode { get => GlueMode_Element.Data; set => GlueMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.Glue.Mode>, global::FrooxEngine.Glue.Mode> GlueMode_Element = new();
public global::System.Boolean Active { get => Active_Element.Data; set => Active_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Active_Element = new();
public global::System.Single DryTime { get => DryTime_Element.Data; set => DryTime_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> DryTime_Element = new();
public global::System.Double Expire { get => Expire_Element.Data; set => Expire_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Double>, global::System.Double> Expire_Element = new();
public global::FrooxEngine.User GluingUser { get => GluingUser_Element.Data; set => GluingUser_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.User>, global::FrooxEngine.User> GluingUser_Element = new();
public global::System.Boolean _forceDry { get => _forceDry_Element.Data; set => _forceDry_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _forceDry_Element = new();
public global::System.Boolean isDrying { get => isDrying_Element.Data; set => isDrying_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> isDrying_Element = new();
public global::System.Double dryStartTime { get => dryStartTime_Element.Data; set => dryStartTime_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Double>, global::System.Double> dryStartTime_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("GlueMode", GlueMode_Element.ToLinkField(context));
members.Add("Active", Active_Element.ToLinkField(context));
members.Add("DryTime", DryTime_Element.ToLinkField(context));
members.Add("Expire", Expire_Element.ToLinkField(context));
members.Add("GluingUser", GluingUser_Element.ToLinkReference(context));
members.Add("_forceDry", _forceDry_Element.ToLinkField(context));
members.Add("isDrying", isDrying_Element.ToLinkField(context));
members.Add("dryStartTime", dryStartTime_Element.ToLinkField(context));
}

}
}
