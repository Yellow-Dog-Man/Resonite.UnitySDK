
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.StaticAudioClip
// Generated on: čtvrtek 26. února 2026 12:26:46
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.StaticAudioClip")]
public partial class StaticAudioClip : global::FrooxEngine.StaticAssetProvider<global::FrooxEngine.AudioClip,global::Elements.Assets.DummyMetadata,global::FrooxEngine.AudioClipVariantDescriptor>

{
    public global::FrooxEngine.AudioLoadMode LoadMode { get => LoadMode_Element.Data; set => LoadMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.AudioLoadMode>, global::FrooxEngine.AudioLoadMode> LoadMode_Element = new();
public global::FrooxEngine.SampleRateMode SampleRateMode { get => SampleRateMode_Element.Data; set => SampleRateMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.SampleRateMode>, global::FrooxEngine.SampleRateMode> SampleRateMode_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LoadMode", LoadMode_Element.ToLinkField(context));
members.Add("SampleRateMode", SampleRateMode_Element.ToLinkField(context));
}

}
}
