
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SlicingVolumeVisualizer
// Generated on: úterý 24. února 2026 18:20:28
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SlicingVolumeVisualizer")]
public partial class SlicingVolumeVisualizer : global::FrooxEngine.Component

{
    public global::FrooxEngine.VolumeUnlitMaterial Material;
public global::System.Boolean AutoScale;
public global::FrooxEngine.MeshRenderer _renderer;
public global::FrooxEngine.BoxMesh _mesh;
public global::FrooxEngine.BoxCollider _collider;
public global::FrooxEngine.IField<UnityEngine.Vector3> _scale;
public System.Collections.Generic.List<global::FrooxEngine.VolumePlaneSlicer> Slicers;
public global::FrooxEngine.SyncList<global::FrooxEngine.VolumeUnlitMaterial.SlicePlane> _slicePlanes;
public global::FrooxEngine.SyncList<global::FrooxEngine.VolumeUnlitMaterial.Highlight> _highlights;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Material", Material.ToResoniteReference(context));
members.Add("AutoScale", AutoScale.ToResoniteLinkField());
members.Add("_renderer", _renderer.ToResoniteReference(context));
members.Add("_mesh", _mesh.ToResoniteReference(context));
members.Add("_collider", _collider.ToResoniteReference(context));
members.Add("_scale", _scale.ToResoniteReference(context));
members.Add("Slicers", new ResoniteLink.SyncList()
{
    Elements = Slicers.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("_slicePlanes", _slicePlanes.ToResoniteReference(context));
members.Add("_highlights", _highlights.ToResoniteReference(context));
}

}
}
