
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioExportable
// Generated on: pátek 6. března 2026 14:18:03
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioExportable")]
public partial class AudioExportable : global::FrooxEngine.Component, global::FrooxEngine.IExportable

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> Audio { get => Audio_Element.Data; set => Audio_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.AudioClip>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip>> Audio_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Audio", Audio_Element.ToLinkReference(context));
}

}
}
