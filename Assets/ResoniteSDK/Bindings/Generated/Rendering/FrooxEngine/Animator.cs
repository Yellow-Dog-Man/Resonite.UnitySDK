
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Animator
// Generated on: úterý 24. února 2026 18:20:06
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Animator")]
public partial class Animator : global::FrooxEngine.Component, global::FrooxEngine.IPlayable, global::FrooxEngine.ICustomInspector

{
    public PlaybackState _playback;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Animation> Clip;
public System.Collections.Generic.List<global::FrooxEngine.IField> Fields;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_playback", _playback.ToResoniteLink());
members.Add("Clip", Clip.ToResoniteReference(context));
members.Add("Fields", new ResoniteLink.SyncList()
{
    Elements = Fields.ConvertList(m => m.ToResoniteReference(context))
});
}

}
}
