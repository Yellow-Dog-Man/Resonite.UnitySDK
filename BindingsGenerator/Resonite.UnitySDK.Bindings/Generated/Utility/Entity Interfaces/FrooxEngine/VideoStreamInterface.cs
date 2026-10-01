
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VideoStreamInterface
// Generated on: pátek 14. srpna 2026 21:58:17
// Resonite version: 2026.8.12.1196
// Resonite Link Version: 0.13.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VideoStreamInterface")]
public partial class VideoStreamInterface : global::FrooxEngine.EntityInterface

{
    public global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D> Texture { get => Texture_Element.Data; set => Texture_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>>, global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture2D>> Texture_Element = new();
public global::FrooxEngine.SyncRef<global::FrooxEngine.IWorldAudioDataSource> Audio { get => Audio_Element.Data; set => Audio_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.SyncRef<global::FrooxEngine.IWorldAudioDataSource>>, global::FrooxEngine.SyncRef<global::FrooxEngine.IWorldAudioDataSource>> Audio_Element = new();
public global::FrooxEngine.IField<global::System.Single> AspectRatio { get => AspectRatio_Element.Data; set => AspectRatio_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Single>>, global::FrooxEngine.IField<global::System.Single>> AspectRatio_Element = new();
public global::FrooxEngine.IField<global::System.String> StreamSinkURL { get => StreamSinkURL_Element.Data; set => StreamSinkURL_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> StreamSinkURL_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Texture", Texture_Element.ToLinkReference(context));
members.Add("Audio", Audio_Element.ToLinkReference(context));
members.Add("AspectRatio", AspectRatio_Element.ToLinkReference(context));
members.Add("StreamSinkURL", StreamSinkURL_Element.ToLinkReference(context));
}

}
}
