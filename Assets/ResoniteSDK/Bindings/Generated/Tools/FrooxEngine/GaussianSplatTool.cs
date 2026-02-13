
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GaussianSplatTool
// Generated on: pátek 13. února 2026 23:23:07
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GaussianSplatTool")]
public partial class GaussianSplatTool : global::FrooxEngine.Tool

{
    public global::FrooxEngine.GaussianSplatTool.OperationMode Mode;
public global::FrooxEngine.GaussianSplatTool.BoxInterface BoxSelectionTemplate;
public global::FrooxEngine.GaussianSplatTool.SphereInterface SphereSelectionTemplate;
public global::FrooxEngine.GaussianSplatTool.CylinderInterface CylinderSelectionTemplate;
public global::FrooxEngine.GaussianSplatTool.BoxInterface _activeBox;
public global::FrooxEngine.GaussianSplatTool.SphereInterface _activeSphere;
public global::FrooxEngine.GaussianSplatTool.CylinderInterface _activeCylinder;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Mode", Mode.ToResoniteLinkField());
members.Add("BoxSelectionTemplate", new ResoniteLink.Reference() { });
members.Add("SphereSelectionTemplate", new ResoniteLink.Reference() { });
members.Add("CylinderSelectionTemplate", new ResoniteLink.Reference() { });
members.Add("_activeBox", new ResoniteLink.Reference() { });
members.Add("_activeSphere", new ResoniteLink.Reference() { });
members.Add("_activeCylinder", new ResoniteLink.Reference() { });
}

}
}
