
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioStreamInterface
// Generated on: středa 25. února 2026 16:14:47
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioStreamInterface")]
public partial class AudioStreamInterface : global::FrooxEngine.EntityInterface

{
    public global::FrooxEngine.SyncRef<global::FrooxEngine.IAudioStream> Source;
public global::FrooxEngine.IField<global::System.Int32> Bitrate;
public global::FrooxEngine.IField<global::System.Single> Volume;
public global::FrooxEngine.IField<global::System.Boolean> Spatialize;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Source", Source.ToResoniteReference(context));
members.Add("Bitrate", Bitrate.ToResoniteReference(context));
members.Add("Volume", Volume.ToResoniteReference(context));
members.Add("Spatialize", Spatialize.ToResoniteReference(context));
}

}
}
