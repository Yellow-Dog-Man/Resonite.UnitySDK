
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ModelImportDialog
// Generated on: úterý 24. února 2026 18:20:26
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ModelImportDialog")]
public partial class ModelImportDialog : global::FrooxEngine.ImportDialog

{
    public global::System.Single _scale;
public global::System.Boolean _autoScale;
public global::FrooxEngine.ModelImportDialog.MaterialType _material;
public global::System.Boolean _preferSpecular;
public global::System.Boolean _rig;
public global::System.Boolean _setupIK;
public global::System.Boolean _debugRig;
public global::System.Boolean _colliders;
public global::System.Boolean _animations;
public global::System.Boolean _snappable;
public global::System.Boolean _timelapse;
public global::System.Boolean _externalTextures;
public global::System.Boolean _grabbable;
public global::System.Boolean _scalable;
public global::System.Boolean _importAtOrigin;
public global::System.Boolean _forceTpose;
public global::System.Boolean _assetsOnObject;
public global::System.Boolean _asPointCloud;
public global::System.Boolean _importImagesByName;
public global::FrooxEngine.ModelImportDialog.AlignmentAxis _importImageAlignment;
public global::System.Boolean _calculateNormals;
public global::System.Boolean _calculateTangents;
public global::System.Boolean _calculateTextureAlpha;
public global::System.Boolean _importVertexColors;
public global::System.Boolean _importAlbedoColor;
public global::System.Boolean _importEmissive;
public global::System.Boolean _importBones;
public global::System.Boolean _importLights;
public global::System.Boolean _makeDualSided;
public global::System.Boolean _makeFlatShaded;
public global::System.Boolean _deduplicateInstances;
public global::System.Boolean _optimizeModel;
public global::System.Boolean _splitSubmeshes;
public global::System.Boolean _generateRandomColors;
public global::System.Boolean _spawnMaterialOrbs;
public global::System.Int32 _maxTextureSize;
public global::FrooxEngine.TextureConversion _textureConversion;
public global::System.Boolean _forcePointFiltering;
public global::System.Boolean _forceNoMipMaps;
public global::System.Boolean _forceUncompressed;
public global::System.Boolean ForceAsPointCloud;
public global::System.Boolean PotentialGaussianSplat;
public global::System.Boolean _flipY;
public global::System.Boolean _encodeSPZ;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_scale", _scale.ToResoniteLinkField());
members.Add("_autoScale", _autoScale.ToResoniteLinkField());
members.Add("_material", _material.ToResoniteLinkField());
members.Add("_preferSpecular", _preferSpecular.ToResoniteLinkField());
members.Add("_rig", _rig.ToResoniteLinkField());
members.Add("_setupIK", _setupIK.ToResoniteLinkField());
members.Add("_debugRig", _debugRig.ToResoniteLinkField());
members.Add("_colliders", _colliders.ToResoniteLinkField());
members.Add("_animations", _animations.ToResoniteLinkField());
members.Add("_snappable", _snappable.ToResoniteLinkField());
members.Add("_timelapse", _timelapse.ToResoniteLinkField());
members.Add("_externalTextures", _externalTextures.ToResoniteLinkField());
members.Add("_grabbable", _grabbable.ToResoniteLinkField());
members.Add("_scalable", _scalable.ToResoniteLinkField());
members.Add("_importAtOrigin", _importAtOrigin.ToResoniteLinkField());
members.Add("_forceTpose", _forceTpose.ToResoniteLinkField());
members.Add("_assetsOnObject", _assetsOnObject.ToResoniteLinkField());
members.Add("_asPointCloud", _asPointCloud.ToResoniteLinkField());
members.Add("_importImagesByName", _importImagesByName.ToResoniteLinkField());
members.Add("_importImageAlignment", _importImageAlignment.ToResoniteLinkField());
members.Add("_calculateNormals", _calculateNormals.ToResoniteLinkField());
members.Add("_calculateTangents", _calculateTangents.ToResoniteLinkField());
members.Add("_calculateTextureAlpha", _calculateTextureAlpha.ToResoniteLinkField());
members.Add("_importVertexColors", _importVertexColors.ToResoniteLinkField());
members.Add("_importAlbedoColor", _importAlbedoColor.ToResoniteLinkField());
members.Add("_importEmissive", _importEmissive.ToResoniteLinkField());
members.Add("_importBones", _importBones.ToResoniteLinkField());
members.Add("_importLights", _importLights.ToResoniteLinkField());
members.Add("_makeDualSided", _makeDualSided.ToResoniteLinkField());
members.Add("_makeFlatShaded", _makeFlatShaded.ToResoniteLinkField());
members.Add("_deduplicateInstances", _deduplicateInstances.ToResoniteLinkField());
members.Add("_optimizeModel", _optimizeModel.ToResoniteLinkField());
members.Add("_splitSubmeshes", _splitSubmeshes.ToResoniteLinkField());
members.Add("_generateRandomColors", _generateRandomColors.ToResoniteLinkField());
members.Add("_spawnMaterialOrbs", _spawnMaterialOrbs.ToResoniteLinkField());
members.Add("_maxTextureSize", _maxTextureSize.ToResoniteLinkField());
members.Add("_textureConversion", _textureConversion.ToResoniteLinkField());
members.Add("_forcePointFiltering", _forcePointFiltering.ToResoniteLinkField());
members.Add("_forceNoMipMaps", _forceNoMipMaps.ToResoniteLinkField());
members.Add("_forceUncompressed", _forceUncompressed.ToResoniteLinkField());
members.Add("ForceAsPointCloud", ForceAsPointCloud.ToResoniteLinkField());
members.Add("PotentialGaussianSplat", PotentialGaussianSplat.ToResoniteLinkField());
members.Add("_flipY", _flipY.ToResoniteLinkField());
members.Add("_encodeSPZ", _encodeSPZ.ToResoniteLinkField());
}

}
}
