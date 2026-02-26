
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioPlayerInterface
// Generated on: čtvrtek 26. února 2026 10:04:50
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioPlayerInterface")]
public partial class AudioPlayerInterface : global::FrooxEngine.EntityInterface

{
    public global::FrooxEngine.IField<System.Uri> URL { get => URL_Element.Data; set => URL_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<System.Uri>>, global::FrooxEngine.IField<System.Uri>> URL_Element = new();
public global::FrooxEngine.AssetRef<global::FrooxEngine.AudioClip> Clip { get => Clip_Element.Data; set => Clip_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.AssetRef<global::FrooxEngine.AudioClip>>, global::FrooxEngine.AssetRef<global::FrooxEngine.AudioClip>> Clip_Element = new();
public global::FrooxEngine.IField<global::FrooxEngine.AudioTypeGroup> Group { get => Group_Element.Data; set => Group_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::FrooxEngine.AudioTypeGroup>>, global::FrooxEngine.IField<global::FrooxEngine.AudioTypeGroup>> Group_Element = new();
public global::FrooxEngine.IField<global::System.Single> Volume { get => Volume_Element.Data; set => Volume_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Single>>, global::FrooxEngine.IField<global::System.Single>> Volume_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> Spatialize { get => Spatialize_Element.Data; set => Spatialize_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>> Spatialize_Element = new();
public global::FrooxEngine.IField<global::System.Single> Doppler { get => Doppler_Element.Data; set => Doppler_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Single>>, global::FrooxEngine.IField<global::System.Single>> Doppler_Element = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> DefaultAudioClip { get => DefaultAudioClip_Element.Data; set => DefaultAudioClip_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.AudioClip>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip>> DefaultAudioClip_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("URL", URL_Element.Data.ToResoniteReference(context));
members.Add("Clip", Clip_Element.Data.ToResoniteReference(context));
members.Add("Group", Group_Element.Data.ToResoniteReference(context));
members.Add("Volume", Volume_Element.Data.ToResoniteReference(context));
members.Add("Spatialize", Spatialize_Element.Data.ToResoniteReference(context));
members.Add("Doppler", Doppler_Element.Data.ToResoniteReference(context));
members.Add("DefaultAudioClip", DefaultAudioClip_Element.Data.ToResoniteReference(context));
}

}
}
