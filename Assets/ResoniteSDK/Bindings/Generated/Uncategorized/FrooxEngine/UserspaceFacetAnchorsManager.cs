
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserspaceFacetAnchorsManager
// Generated on: čtvrtek 19. února 2026 8:00:31
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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
    public global::System.Boolean Open;
public global::System.Boolean UseFacetAnchors;
public global::Renderite.Shared.Chirality Toggle;
public global::System.Single AnimSpeed;
public global::FrooxEngine.UserspaceRadiantDash Dash;
public global::System.String ProfileName;
public System.Collections.Generic.List<global::FrooxEngine.UserspaceFacetAnchorsManager.Data> Anchors;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Open", Open.ToResoniteLinkField());
members.Add("UseFacetAnchors", UseFacetAnchors.ToResoniteLinkField());
members.Add("Toggle", Toggle.ToResoniteLinkField());
members.Add("AnimSpeed", AnimSpeed.ToResoniteLinkField());
members.Add("Dash", Dash.ToResoniteReference(context));
members.Add("ProfileName", ProfileName.ToResoniteLinkField());
members.Add("Anchors", new ResoniteLink.SyncList()
{
    Elements = Anchors.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
