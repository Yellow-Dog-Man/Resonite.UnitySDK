
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SlicingVolumeVisualizer
// Generated on: čtvrtek 26. února 2026 10:04:48
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SlicingVolumeVisualizer")]
public partial class SlicingVolumeVisualizer : global::FrooxEngine.Component

{
    public global::FrooxEngine.VolumeUnlitMaterial Material { get => Material_Element.Data; set => Material_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.VolumeUnlitMaterial>, global::FrooxEngine.VolumeUnlitMaterial> Material_Element = new();
public global::System.Boolean AutoScale { get => AutoScale_Element.Data; set => AutoScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AutoScale_Element = new();
public global::FrooxEngine.MeshRenderer _renderer { get => _renderer_Element.Data; set => _renderer_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.MeshRenderer>, global::FrooxEngine.MeshRenderer> _renderer_Element = new();
public global::FrooxEngine.BoxMesh _mesh { get => _mesh_Element.Data; set => _mesh_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.BoxMesh>, global::FrooxEngine.BoxMesh> _mesh_Element = new();
public global::FrooxEngine.BoxCollider _collider { get => _collider_Element.Data; set => _collider_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.BoxCollider>, global::FrooxEngine.BoxCollider> _collider_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _scale { get => _scale_Element.Data; set => _scale_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _scale_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncRelayList<global::FrooxEngine.VolumePlaneSlicer>, global::FrooxEngine.VolumePlaneSlicer, Field<global::FrooxEngine.RelayRef<global::FrooxEngine.VolumePlaneSlicer>, global::FrooxEngine.VolumePlaneSlicer>> Slicers = new();
public global::FrooxEngine.SyncList<global::FrooxEngine.VolumeUnlitMaterial.SlicePlane> _slicePlanes { get => _slicePlanes_Element.Data; set => _slicePlanes_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.SyncList<global::FrooxEngine.VolumeUnlitMaterial.SlicePlane>>, global::FrooxEngine.SyncList<global::FrooxEngine.VolumeUnlitMaterial.SlicePlane>> _slicePlanes_Element = new();
public global::FrooxEngine.SyncList<global::FrooxEngine.VolumeUnlitMaterial.Highlight> _highlights { get => _highlights_Element.Data; set => _highlights_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.SyncList<global::FrooxEngine.VolumeUnlitMaterial.Highlight>>, global::FrooxEngine.SyncList<global::FrooxEngine.VolumeUnlitMaterial.Highlight>> _highlights_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Material", Material_Element.Data.ToResoniteReference(context));
members.Add("AutoScale", AutoScale_Element.Data.ToResoniteLinkField());
members.Add("_renderer", _renderer_Element.Data.ToResoniteReference(context));
members.Add("_mesh", _mesh_Element.Data.ToResoniteReference(context));
members.Add("_collider", _collider_Element.Data.ToResoniteReference(context));
members.Add("_scale", _scale_Element.Data.ToResoniteReference(context));
members.Add("Slicers", new ResoniteLink.SyncList()
{
    Elements = Slicers.Data.ConvertList(m => m.Data.ToResoniteReference(context))
});
members.Add("_slicePlanes", _slicePlanes_Element.Data.ToResoniteReference(context));
members.Add("_highlights", _highlights_Element.Data.ToResoniteReference(context));
}

}
}
