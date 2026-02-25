
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TextureRefEditor
// Generated on: středa 25. února 2026 16:14:43
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TextureRefEditor")]
public partial class TextureRefEditor : global::FrooxEngine.Component, global::FrooxEngine.UIX.IUIGrabReceiver, global::FrooxEngine.UIX.IUIGrabbable

{
    public global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D> _targetRef;
public global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D> _drive;
public global::FrooxEngine.UIX.Button _clearReferenceButton;
public global::FrooxEngine.UIX.Button _openInspectorButton;
public global::FrooxEngine.UIX.Button _copyTextureButton;
public global::FrooxEngine.UIX.Button _pasteTextureButton;
public global::FrooxEngine.IField<global::System.String> _referenceText;
public global::FrooxEngine.IField<global::System.String> _infoText;
public global::System.Boolean _isNormalMap;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_targetRef", _targetRef.ToResoniteReference(context));
members.Add("_drive", _drive.ToResoniteReference(context));
members.Add("_clearReferenceButton", _clearReferenceButton.ToResoniteReference(context));
members.Add("_openInspectorButton", _openInspectorButton.ToResoniteReference(context));
members.Add("_copyTextureButton", _copyTextureButton.ToResoniteReference(context));
members.Add("_pasteTextureButton", _pasteTextureButton.ToResoniteReference(context));
members.Add("_referenceText", _referenceText.ToResoniteReference(context));
members.Add("_infoText", _infoText.ToResoniteReference(context));
members.Add("_isNormalMap", _isNormalMap.ToResoniteLinkField());
}

}
}
