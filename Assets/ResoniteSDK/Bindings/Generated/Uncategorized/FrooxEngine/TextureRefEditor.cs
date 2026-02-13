
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TextureRefEditor
// Generated on: pátek 13. února 2026 23:23:18
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("_targetRef", new ResoniteLink.Reference() { });
members.Add("_drive", new ResoniteLink.Reference() { });
members.Add("_clearReferenceButton", new ResoniteLink.Reference() { });
members.Add("_openInspectorButton", new ResoniteLink.Reference() { });
members.Add("_copyTextureButton", new ResoniteLink.Reference() { });
members.Add("_pasteTextureButton", new ResoniteLink.Reference() { });
members.Add("_referenceText", new ResoniteLink.Reference() { });
members.Add("_infoText", new ResoniteLink.Reference() { });
members.Add("_isNormalMap", _isNormalMap.ToResoniteLinkField());
}

}
}
