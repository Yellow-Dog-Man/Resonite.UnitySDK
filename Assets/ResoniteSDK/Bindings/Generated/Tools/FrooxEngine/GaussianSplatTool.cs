
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GaussianSplatTool
// Generated on: úterý 24. února 2026 18:20:11
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Mode", Mode.ToResoniteLinkField());
members.Add("BoxSelectionTemplate", BoxSelectionTemplate.ToResoniteReference(context));
members.Add("SphereSelectionTemplate", SphereSelectionTemplate.ToResoniteReference(context));
members.Add("CylinderSelectionTemplate", CylinderSelectionTemplate.ToResoniteReference(context));
members.Add("_activeBox", _activeBox.ToResoniteReference(context));
members.Add("_activeSphere", _activeSphere.ToResoniteReference(context));
members.Add("_activeCylinder", _activeCylinder.ToResoniteReference(context));
}

}
}
