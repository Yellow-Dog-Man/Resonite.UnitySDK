
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PagingControlFacetPreset
// Generated on: pondělí 2. března 2026 17:53:26
// Resonite version: 2026.3.2.1000
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PagingControlFacetPreset")]
public partial class PagingControlFacetPreset : global::FrooxEngine.FacetPreset

{
    public global::FrooxEngine.PagingControl _pagingControl { get => _pagingControl_Element.Data; set => _pagingControl_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.PagingControl>, global::FrooxEngine.PagingControl> _pagingControl_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_pagingControl", _pagingControl_Element.ToLinkReference(context));
}

}
}
