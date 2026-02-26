
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GaussianSplatTool
// Generated on: čtvrtek 26. února 2026 12:28:05
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GaussianSplatTool")]
public partial class GaussianSplatTool : global::FrooxEngine.Tool

{
    public global::FrooxEngine.GaussianSplatTool.OperationMode Mode { get => Mode_Element.Data; set => Mode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.GaussianSplatTool.OperationMode>, global::FrooxEngine.GaussianSplatTool.OperationMode> Mode_Element = new();
public global::FrooxEngine.GaussianSplatTool.BoxInterface BoxSelectionTemplate { get => BoxSelectionTemplate_Element.Data; set => BoxSelectionTemplate_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.GaussianSplatTool.BoxInterface>, global::FrooxEngine.GaussianSplatTool.BoxInterface> BoxSelectionTemplate_Element = new();
public global::FrooxEngine.GaussianSplatTool.SphereInterface SphereSelectionTemplate { get => SphereSelectionTemplate_Element.Data; set => SphereSelectionTemplate_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.GaussianSplatTool.SphereInterface>, global::FrooxEngine.GaussianSplatTool.SphereInterface> SphereSelectionTemplate_Element = new();
public global::FrooxEngine.GaussianSplatTool.CylinderInterface CylinderSelectionTemplate { get => CylinderSelectionTemplate_Element.Data; set => CylinderSelectionTemplate_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.GaussianSplatTool.CylinderInterface>, global::FrooxEngine.GaussianSplatTool.CylinderInterface> CylinderSelectionTemplate_Element = new();
public global::FrooxEngine.GaussianSplatTool.BoxInterface _activeBox { get => _activeBox_Element.Data; set => _activeBox_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.GaussianSplatTool.BoxInterface>, global::FrooxEngine.GaussianSplatTool.BoxInterface> _activeBox_Element = new();
public global::FrooxEngine.GaussianSplatTool.SphereInterface _activeSphere { get => _activeSphere_Element.Data; set => _activeSphere_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.GaussianSplatTool.SphereInterface>, global::FrooxEngine.GaussianSplatTool.SphereInterface> _activeSphere_Element = new();
public global::FrooxEngine.GaussianSplatTool.CylinderInterface _activeCylinder { get => _activeCylinder_Element.Data; set => _activeCylinder_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.GaussianSplatTool.CylinderInterface>, global::FrooxEngine.GaussianSplatTool.CylinderInterface> _activeCylinder_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Mode", Mode_Element.ToLinkField(context));
members.Add("BoxSelectionTemplate", BoxSelectionTemplate_Element.ToLinkReference(context));
members.Add("SphereSelectionTemplate", SphereSelectionTemplate_Element.ToLinkReference(context));
members.Add("CylinderSelectionTemplate", CylinderSelectionTemplate_Element.ToLinkReference(context));
members.Add("_activeBox", _activeBox_Element.ToLinkReference(context));
members.Add("_activeSphere", _activeSphere_Element.ToLinkReference(context));
members.Add("_activeCylinder", _activeCylinder_Element.ToLinkReference(context));
}

}
}
