
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioStreamInterface
// Generated on: pátek 13. února 2026 23:23:21
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioStreamInterface")]
public partial class AudioStreamInterface : global::FrooxEngine.EntityInterface

{
    public global::FrooxEngine.SyncRef<global::FrooxEngine.IAudioStream> Source;
public global::FrooxEngine.IField<global::System.Int32> Bitrate;
public global::FrooxEngine.IField<global::System.Single> Volume;
public global::FrooxEngine.IField<global::System.Boolean> Spatialize;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Source", new ResoniteLink.Reference() { });
members.Add("Bitrate", new ResoniteLink.Reference() { });
members.Add("Volume", new ResoniteLink.Reference() { });
members.Add("Spatialize", new ResoniteLink.Reference() { });
}

}
}
