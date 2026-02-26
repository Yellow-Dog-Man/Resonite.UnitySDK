
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ModelImportDialog
// Generated on: čtvrtek 26. února 2026 10:04:47
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ModelImportDialog")]
public partial class ModelImportDialog : global::FrooxEngine.ImportDialog

{
    public global::System.Single _scale { get => _scale_Element.Data; set => _scale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> _scale_Element = new();
public global::System.Boolean _autoScale { get => _autoScale_Element.Data; set => _autoScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _autoScale_Element = new();
public global::FrooxEngine.ModelImportDialog.MaterialType _material { get => _material_Element.Data; set => _material_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ModelImportDialog.MaterialType>, global::FrooxEngine.ModelImportDialog.MaterialType> _material_Element = new();
public global::System.Boolean _preferSpecular { get => _preferSpecular_Element.Data; set => _preferSpecular_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _preferSpecular_Element = new();
public global::System.Boolean _rig { get => _rig_Element.Data; set => _rig_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _rig_Element = new();
public global::System.Boolean _setupIK { get => _setupIK_Element.Data; set => _setupIK_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _setupIK_Element = new();
public global::System.Boolean _debugRig { get => _debugRig_Element.Data; set => _debugRig_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _debugRig_Element = new();
public global::System.Boolean _colliders { get => _colliders_Element.Data; set => _colliders_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _colliders_Element = new();
public global::System.Boolean _animations { get => _animations_Element.Data; set => _animations_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _animations_Element = new();
public global::System.Boolean _snappable { get => _snappable_Element.Data; set => _snappable_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _snappable_Element = new();
public global::System.Boolean _timelapse { get => _timelapse_Element.Data; set => _timelapse_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _timelapse_Element = new();
public global::System.Boolean _externalTextures { get => _externalTextures_Element.Data; set => _externalTextures_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _externalTextures_Element = new();
public global::System.Boolean _grabbable { get => _grabbable_Element.Data; set => _grabbable_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _grabbable_Element = new();
public global::System.Boolean _scalable { get => _scalable_Element.Data; set => _scalable_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _scalable_Element = new();
public global::System.Boolean _importAtOrigin { get => _importAtOrigin_Element.Data; set => _importAtOrigin_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _importAtOrigin_Element = new();
public global::System.Boolean _forceTpose { get => _forceTpose_Element.Data; set => _forceTpose_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _forceTpose_Element = new();
public global::System.Boolean _assetsOnObject { get => _assetsOnObject_Element.Data; set => _assetsOnObject_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _assetsOnObject_Element = new();
public global::System.Boolean _asPointCloud { get => _asPointCloud_Element.Data; set => _asPointCloud_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _asPointCloud_Element = new();
public global::System.Boolean _importImagesByName { get => _importImagesByName_Element.Data; set => _importImagesByName_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _importImagesByName_Element = new();
public global::FrooxEngine.ModelImportDialog.AlignmentAxis _importImageAlignment { get => _importImageAlignment_Element.Data; set => _importImageAlignment_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ModelImportDialog.AlignmentAxis>, global::FrooxEngine.ModelImportDialog.AlignmentAxis> _importImageAlignment_Element = new();
public global::System.Boolean _calculateNormals { get => _calculateNormals_Element.Data; set => _calculateNormals_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _calculateNormals_Element = new();
public global::System.Boolean _calculateTangents { get => _calculateTangents_Element.Data; set => _calculateTangents_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _calculateTangents_Element = new();
public global::System.Boolean _calculateTextureAlpha { get => _calculateTextureAlpha_Element.Data; set => _calculateTextureAlpha_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _calculateTextureAlpha_Element = new();
public global::System.Boolean _importVertexColors { get => _importVertexColors_Element.Data; set => _importVertexColors_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _importVertexColors_Element = new();
public global::System.Boolean _importAlbedoColor { get => _importAlbedoColor_Element.Data; set => _importAlbedoColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _importAlbedoColor_Element = new();
public global::System.Boolean _importEmissive { get => _importEmissive_Element.Data; set => _importEmissive_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _importEmissive_Element = new();
public global::System.Boolean _importBones { get => _importBones_Element.Data; set => _importBones_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _importBones_Element = new();
public global::System.Boolean _importLights { get => _importLights_Element.Data; set => _importLights_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _importLights_Element = new();
public global::System.Boolean _makeDualSided { get => _makeDualSided_Element.Data; set => _makeDualSided_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _makeDualSided_Element = new();
public global::System.Boolean _makeFlatShaded { get => _makeFlatShaded_Element.Data; set => _makeFlatShaded_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _makeFlatShaded_Element = new();
public global::System.Boolean _deduplicateInstances { get => _deduplicateInstances_Element.Data; set => _deduplicateInstances_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _deduplicateInstances_Element = new();
public global::System.Boolean _optimizeModel { get => _optimizeModel_Element.Data; set => _optimizeModel_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _optimizeModel_Element = new();
public global::System.Boolean _splitSubmeshes { get => _splitSubmeshes_Element.Data; set => _splitSubmeshes_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _splitSubmeshes_Element = new();
public global::System.Boolean _generateRandomColors { get => _generateRandomColors_Element.Data; set => _generateRandomColors_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _generateRandomColors_Element = new();
public global::System.Boolean _spawnMaterialOrbs { get => _spawnMaterialOrbs_Element.Data; set => _spawnMaterialOrbs_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _spawnMaterialOrbs_Element = new();
public global::System.Int32 _maxTextureSize { get => _maxTextureSize_Element.Data; set => _maxTextureSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> _maxTextureSize_Element = new();
public global::FrooxEngine.TextureConversion _textureConversion { get => _textureConversion_Element.Data; set => _textureConversion_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.TextureConversion>, global::FrooxEngine.TextureConversion> _textureConversion_Element = new();
public global::System.Boolean _forcePointFiltering { get => _forcePointFiltering_Element.Data; set => _forcePointFiltering_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _forcePointFiltering_Element = new();
public global::System.Boolean _forceNoMipMaps { get => _forceNoMipMaps_Element.Data; set => _forceNoMipMaps_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _forceNoMipMaps_Element = new();
public global::System.Boolean _forceUncompressed { get => _forceUncompressed_Element.Data; set => _forceUncompressed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _forceUncompressed_Element = new();
public global::System.Boolean ForceAsPointCloud { get => ForceAsPointCloud_Element.Data; set => ForceAsPointCloud_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ForceAsPointCloud_Element = new();
public global::System.Boolean PotentialGaussianSplat { get => PotentialGaussianSplat_Element.Data; set => PotentialGaussianSplat_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PotentialGaussianSplat_Element = new();
public global::System.Boolean _flipY { get => _flipY_Element.Data; set => _flipY_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _flipY_Element = new();
public global::System.Boolean _encodeSPZ { get => _encodeSPZ_Element.Data; set => _encodeSPZ_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _encodeSPZ_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_scale", _scale_Element.Data.ToResoniteLinkField());
members.Add("_autoScale", _autoScale_Element.Data.ToResoniteLinkField());
members.Add("_material", _material_Element.Data.ToResoniteLinkField());
members.Add("_preferSpecular", _preferSpecular_Element.Data.ToResoniteLinkField());
members.Add("_rig", _rig_Element.Data.ToResoniteLinkField());
members.Add("_setupIK", _setupIK_Element.Data.ToResoniteLinkField());
members.Add("_debugRig", _debugRig_Element.Data.ToResoniteLinkField());
members.Add("_colliders", _colliders_Element.Data.ToResoniteLinkField());
members.Add("_animations", _animations_Element.Data.ToResoniteLinkField());
members.Add("_snappable", _snappable_Element.Data.ToResoniteLinkField());
members.Add("_timelapse", _timelapse_Element.Data.ToResoniteLinkField());
members.Add("_externalTextures", _externalTextures_Element.Data.ToResoniteLinkField());
members.Add("_grabbable", _grabbable_Element.Data.ToResoniteLinkField());
members.Add("_scalable", _scalable_Element.Data.ToResoniteLinkField());
members.Add("_importAtOrigin", _importAtOrigin_Element.Data.ToResoniteLinkField());
members.Add("_forceTpose", _forceTpose_Element.Data.ToResoniteLinkField());
members.Add("_assetsOnObject", _assetsOnObject_Element.Data.ToResoniteLinkField());
members.Add("_asPointCloud", _asPointCloud_Element.Data.ToResoniteLinkField());
members.Add("_importImagesByName", _importImagesByName_Element.Data.ToResoniteLinkField());
members.Add("_importImageAlignment", _importImageAlignment_Element.Data.ToResoniteLinkField());
members.Add("_calculateNormals", _calculateNormals_Element.Data.ToResoniteLinkField());
members.Add("_calculateTangents", _calculateTangents_Element.Data.ToResoniteLinkField());
members.Add("_calculateTextureAlpha", _calculateTextureAlpha_Element.Data.ToResoniteLinkField());
members.Add("_importVertexColors", _importVertexColors_Element.Data.ToResoniteLinkField());
members.Add("_importAlbedoColor", _importAlbedoColor_Element.Data.ToResoniteLinkField());
members.Add("_importEmissive", _importEmissive_Element.Data.ToResoniteLinkField());
members.Add("_importBones", _importBones_Element.Data.ToResoniteLinkField());
members.Add("_importLights", _importLights_Element.Data.ToResoniteLinkField());
members.Add("_makeDualSided", _makeDualSided_Element.Data.ToResoniteLinkField());
members.Add("_makeFlatShaded", _makeFlatShaded_Element.Data.ToResoniteLinkField());
members.Add("_deduplicateInstances", _deduplicateInstances_Element.Data.ToResoniteLinkField());
members.Add("_optimizeModel", _optimizeModel_Element.Data.ToResoniteLinkField());
members.Add("_splitSubmeshes", _splitSubmeshes_Element.Data.ToResoniteLinkField());
members.Add("_generateRandomColors", _generateRandomColors_Element.Data.ToResoniteLinkField());
members.Add("_spawnMaterialOrbs", _spawnMaterialOrbs_Element.Data.ToResoniteLinkField());
members.Add("_maxTextureSize", _maxTextureSize_Element.Data.ToResoniteLinkField());
members.Add("_textureConversion", _textureConversion_Element.Data.ToResoniteLinkField());
members.Add("_forcePointFiltering", _forcePointFiltering_Element.Data.ToResoniteLinkField());
members.Add("_forceNoMipMaps", _forceNoMipMaps_Element.Data.ToResoniteLinkField());
members.Add("_forceUncompressed", _forceUncompressed_Element.Data.ToResoniteLinkField());
members.Add("ForceAsPointCloud", ForceAsPointCloud_Element.Data.ToResoniteLinkField());
members.Add("PotentialGaussianSplat", PotentialGaussianSplat_Element.Data.ToResoniteLinkField());
members.Add("_flipY", _flipY_Element.Data.ToResoniteLinkField());
members.Add("_encodeSPZ", _encodeSPZ_Element.Data.ToResoniteLinkField());
}

}
}
