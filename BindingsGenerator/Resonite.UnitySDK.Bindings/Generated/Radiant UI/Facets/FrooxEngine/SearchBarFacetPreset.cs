
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SearchBarFacetPreset
// Generated on: čtvrtek 26. února 2026 10:04:36
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SearchBarFacetPreset")]
public partial class SearchBarFacetPreset : global::FrooxEngine.FacetPreset

{
    public global::FrooxEngine.RadiantSearchBar _searchBar { get => _searchBar_Element.Data; set => _searchBar_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.RadiantSearchBar>, global::FrooxEngine.RadiantSearchBar> _searchBar_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_searchBar", _searchBar_Element.Data.ToResoniteReference(context));
}

}
}
