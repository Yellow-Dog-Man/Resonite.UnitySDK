
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserspaceFacetAnchorsManager
// Generated on: pátek 13. února 2026 23:23:18
// Resonite version: 2026.2.12.359
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Open", Open.ToResoniteLinkField());
members.Add("UseFacetAnchors", UseFacetAnchors.ToResoniteLinkField());
members.Add("Toggle", Toggle.ToResoniteLinkField());
members.Add("AnimSpeed", AnimSpeed.ToResoniteLinkField());
members.Add("Dash", new ResoniteLink.Reference() { });
members.Add("ProfileName", ProfileName.ToResoniteLinkField());
members.Add("Anchors", new ResoniteLink.SyncList()
{
    Elements = Anchors.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() })
});
}

}
}
