
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TextureRefEditor
// Generated on: čtvrtek 26. února 2026 12:28:13
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TextureRefEditor")]
public partial class TextureRefEditor : global::FrooxEngine.Component, global::FrooxEngine.UIX.IUIGrabReceiver, global::FrooxEngine.UIX.IUIGrabbable

{
    public global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D> _targetRef { get => _targetRef_Element.Data; set => _targetRef_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>>, global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>> _targetRef_Element = new();
public global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D> _drive { get => _drive_Element.Data; set => _drive_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>>, global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>> _drive_Element = new();
public global::FrooxEngine.UIX.Button _clearReferenceButton { get => _clearReferenceButton_Element.Data; set => _clearReferenceButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _clearReferenceButton_Element = new();
public global::FrooxEngine.UIX.Button _openInspectorButton { get => _openInspectorButton_Element.Data; set => _openInspectorButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _openInspectorButton_Element = new();
public global::FrooxEngine.UIX.Button _copyTextureButton { get => _copyTextureButton_Element.Data; set => _copyTextureButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _copyTextureButton_Element = new();
public global::FrooxEngine.UIX.Button _pasteTextureButton { get => _pasteTextureButton_Element.Data; set => _pasteTextureButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _pasteTextureButton_Element = new();
public global::FrooxEngine.IField<global::System.String> _referenceText { get => _referenceText_Element.Data; set => _referenceText_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.String>, global::FrooxEngine.IField<global::System.String>> _referenceText_Element = new();
public global::FrooxEngine.IField<global::System.String> _infoText { get => _infoText_Element.Data; set => _infoText_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.String>, global::FrooxEngine.IField<global::System.String>> _infoText_Element = new();
public global::System.Boolean _isNormalMap { get => _isNormalMap_Element.Data; set => _isNormalMap_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _isNormalMap_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_targetRef", _targetRef_Element.ToLinkReference(context));
members.Add("_drive", _drive_Element.ToLinkReference(context));
members.Add("_clearReferenceButton", _clearReferenceButton_Element.ToLinkReference(context));
members.Add("_openInspectorButton", _openInspectorButton_Element.ToLinkReference(context));
members.Add("_copyTextureButton", _copyTextureButton_Element.ToLinkReference(context));
members.Add("_pasteTextureButton", _pasteTextureButton_Element.ToLinkReference(context));
members.Add("_referenceText", _referenceText_Element.ToLinkReference(context));
members.Add("_infoText", _infoText_Element.ToLinkReference(context));
members.Add("_isNormalMap", _isNormalMap_Element.ToLinkField(context));
}

}
}
