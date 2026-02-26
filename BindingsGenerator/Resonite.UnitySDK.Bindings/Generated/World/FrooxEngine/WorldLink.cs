
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WorldLink
// Generated on: čtvrtek 26. února 2026 15:07:58
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.WorldLink")]
public partial class WorldLink : global::FrooxEngine.Component, global::FrooxEngine.IWorldLink

{
    public System.Uri URL { get => URL_Element.Data; set => URL_Element.Data = value; }
public Field<global::FrooxEngine.Sync<System.Uri>, System.Uri> URL_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncFieldList<System.Uri>, System.Uri, Field<global::FrooxEngine.Sync<System.Uri>, System.Uri>> ActiveSessionURLs = new();
public global::FrooxEngine.Userspace.WorldRelation WorldRelation { get => WorldRelation_Element.Data; set => WorldRelation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.Userspace.WorldRelation>, global::FrooxEngine.Userspace.WorldRelation> WorldRelation_Element = new();
public global::System.Boolean AutoFocus { get => AutoFocus_Element.Data; set => AutoFocus_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AutoFocus_Element = new();
public global::System.Boolean GetExisting { get => GetExisting_Element.Data; set => GetExisting_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> GetExisting_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("URL", URL_Element.ToLinkField(context));
members.Add("ActiveSessionURLs", ActiveSessionURLs.ToLinkList(context, m => m.ToLinkField(context)));
members.Add("WorldRelation", WorldRelation_Element.ToLinkField(context));
members.Add("AutoFocus", AutoFocus_Element.ToLinkField(context));
members.Add("GetExisting", GetExisting_Element.ToLinkField(context));
}

}
}
