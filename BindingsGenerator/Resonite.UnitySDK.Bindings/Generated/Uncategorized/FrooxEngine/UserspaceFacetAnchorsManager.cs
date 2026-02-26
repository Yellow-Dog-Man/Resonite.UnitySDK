
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserspaceFacetAnchorsManager
// Generated on: čtvrtek 26. února 2026 15:09:15
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UserspaceFacetAnchorsManager")]
public partial class UserspaceFacetAnchorsManager : global::FrooxEngine.Component

{
    public global::System.Boolean Open { get => Open_Element.Data; set => Open_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Open_Element = new();
public global::System.Boolean UseFacetAnchors { get => UseFacetAnchors_Element.Data; set => UseFacetAnchors_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseFacetAnchors_Element = new();
public global::Renderite.Shared.Chirality Toggle { get => Toggle_Element.Data; set => Toggle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.Chirality>, global::Renderite.Shared.Chirality> Toggle_Element = new();
public global::System.Single AnimSpeed { get => AnimSpeed_Element.Data; set => AnimSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> AnimSpeed_Element = new();
public global::FrooxEngine.UserspaceRadiantDash Dash { get => Dash_Element.Data; set => Dash_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UserspaceRadiantDash>, global::FrooxEngine.UserspaceRadiantDash> Dash_Element = new();
public global::System.String ProfileName { get => ProfileName_Element.Data; set => ProfileName_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> ProfileName_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.UserspaceFacetAnchorsManager.Data>, global::FrooxEngine.UserspaceFacetAnchorsManager.Data> Anchors = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Open", Open_Element.ToLinkField(context));
members.Add("UseFacetAnchors", UseFacetAnchors_Element.ToLinkField(context));
members.Add("Toggle", Toggle_Element.ToLinkField(context));
members.Add("AnimSpeed", AnimSpeed_Element.ToLinkField(context));
members.Add("Dash", Dash_Element.ToLinkReference(context));
members.Add("ProfileName", ProfileName_Element.ToLinkField(context));
members.Add("Anchors", Anchors.ToLinkList(context, m => m.ToLinkSyncObject(context)));
}

}
}
