
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Animator
// Generated on: čtvrtek 26. února 2026 15:09:03
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Animator")]
public partial class Animator : global::FrooxEngine.Component, global::FrooxEngine.IPlayable, global::FrooxEngine.ICustomInspector

{
    public PlaybackState _playback { get => _playback_Element.Data; set => _playback_Element.Data = value; }
public Field<global::FrooxEngine.SyncPlayback, PlaybackState> _playback_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Animation> Clip { get => Clip_Element.Data; set => Clip_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.Animation>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.Animation>> Clip_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncList<global::FrooxEngine.DriveRef<global::FrooxEngine.IField>>, global::FrooxEngine.IField, Reference<global::FrooxEngine.DriveRef<global::FrooxEngine.IField>, global::FrooxEngine.IField>> Fields = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_playback", _playback_Element.ToLinkPlayback(context));
members.Add("Clip", Clip_Element.ToLinkReference(context));
members.Add("Fields", Fields.ToLinkList(context, m => m.ToLinkReference(context)));
}

}
}
