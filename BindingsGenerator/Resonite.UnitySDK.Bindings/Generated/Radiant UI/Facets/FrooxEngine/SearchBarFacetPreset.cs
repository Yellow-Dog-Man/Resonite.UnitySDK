
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SearchBarFacetPreset
// Generated on: pátek 6. března 2026 14:19:02
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SearchBarFacetPreset")]
public partial class SearchBarFacetPreset : global::FrooxEngine.FacetPreset

{
    public global::FrooxEngine.RadiantSearchBar _searchBar { get => _searchBar_Element.Data; set => _searchBar_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.RadiantSearchBar>, global::FrooxEngine.RadiantSearchBar> _searchBar_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_searchBar", _searchBar_Element.ToLinkReference(context));
}

}
}
