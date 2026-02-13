
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PlaybackStateDriver
// Generated on: pátek 13. února 2026 23:21:41
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PlaybackStateDriver")]
public partial class PlaybackStateDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.IPlayable Source;
public global::FrooxEngine.IField<global::System.Boolean> IsPlaying;
public global::FrooxEngine.IField<global::System.Boolean> IsNotPlaying;
public global::FrooxEngine.IField<global::System.Boolean> IsPaused;
public global::FrooxEngine.IField<global::System.Boolean> IsStopped;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Source", new ResoniteLink.Reference() { });
members.Add("IsPlaying", new ResoniteLink.Reference() { });
members.Add("IsNotPlaying", new ResoniteLink.Reference() { });
members.Add("IsPaused", new ResoniteLink.Reference() { });
members.Add("IsStopped", new ResoniteLink.Reference() { });
}

}
}
