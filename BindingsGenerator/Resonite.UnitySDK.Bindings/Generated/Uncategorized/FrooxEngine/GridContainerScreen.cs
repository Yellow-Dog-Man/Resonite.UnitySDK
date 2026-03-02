
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GridContainerScreen
// Generated on: pondělí 2. března 2026 17:53:34
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GridContainerScreen")]
public partial class GridContainerScreen : global::FrooxEngine.RadiantDashScreen

{
    public global::FrooxEngine.GridContainer _gridContainer { get => _gridContainer_Element.Data; set => _gridContainer_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.GridContainer>, global::FrooxEngine.GridContainer> _gridContainer_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_gridContainer", _gridContainer_Element.ToLinkReference(context));
}

}
}
