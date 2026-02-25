
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.StaticAudioClip
// Generated on: středa 25. února 2026 16:13:01
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.StaticAudioClip")]
public partial class StaticAudioClip : global::FrooxEngine.StaticAssetProvider<global::FrooxEngine.AudioClip,global::Elements.Assets.DummyMetadata,global::FrooxEngine.AudioClipVariantDescriptor>

{
    public global::FrooxEngine.AudioLoadMode LoadMode;
public global::FrooxEngine.SampleRateMode SampleRateMode;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LoadMode", LoadMode.ToResoniteLinkField());
members.Add("SampleRateMode", SampleRateMode.ToResoniteLinkField());
}

}
}
