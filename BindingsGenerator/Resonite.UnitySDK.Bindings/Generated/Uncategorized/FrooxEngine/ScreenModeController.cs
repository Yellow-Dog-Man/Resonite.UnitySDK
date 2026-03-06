
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ScreenModeController
// Generated on: pátek 6. března 2026 14:19:10
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ScreenModeController")]
public partial class ScreenModeController : global::FrooxEngine.Component

{
    public global::FrooxEngine.UserspaceRadiantDash _dash { get => _dash_Element.Data; set => _dash_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UserspaceRadiantDash>, global::FrooxEngine.UserspaceRadiantDash> _dash_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> _muteSound { get => _muteSound_Element.Data; set => _muteSound_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.AudioClip>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip>> _muteSound_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> _unmuteSound { get => _unmuteSound_Element.Data; set => _unmuteSound_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.AudioClip>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip>> _unmuteSound_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> _startTalkSound { get => _startTalkSound_Element.Data; set => _startTalkSound_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.AudioClip>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip>> _startTalkSound_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> _stopTalkSound { get => _stopTalkSound_Element.Data; set => _stopTalkSound_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.AudioClip>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip>> _stopTalkSound_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_dash", _dash_Element.ToLinkReference(context));
members.Add("_muteSound", _muteSound_Element.ToLinkReference(context));
members.Add("_unmuteSound", _unmuteSound_Element.ToLinkReference(context));
members.Add("_startTalkSound", _startTalkSound_Element.ToLinkReference(context));
members.Add("_stopTalkSound", _stopTalkSound_Element.ToLinkReference(context));
}

}
}
