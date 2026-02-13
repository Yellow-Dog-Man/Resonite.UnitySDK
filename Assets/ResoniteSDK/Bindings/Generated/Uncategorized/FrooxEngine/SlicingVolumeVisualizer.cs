
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SlicingVolumeVisualizer
// Generated on: pátek 13. února 2026 5:52:36
// Resonite version: 2026.2.13.254
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Material", new ResoniteLink.Reference() { });
members.Add("AutoScale", AutoScale.ToResoniteLinkField());
members.Add("_renderer", new ResoniteLink.Reference() { });
members.Add("_mesh", new ResoniteLink.Reference() { });
members.Add("_collider", new ResoniteLink.Reference() { });
members.Add("_scale", new ResoniteLink.Reference() { });
members.Add("Slicers", new ResoniteLink.SyncList()
{
    Elements = Slicers.Select(m => new ResoniteLink.Reference() { }).ToList<ResoniteLink.Member>()
});
members.Add("_slicePlanes", new ResoniteLink.Reference() { });
members.Add("_highlights", new ResoniteLink.Reference() { });
}

}
}
