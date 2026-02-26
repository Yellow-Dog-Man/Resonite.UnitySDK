
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioStreamInterface
// Generated on: čtvrtek 26. února 2026 12:28:16
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioStreamInterface")]
public partial class AudioStreamInterface : global::FrooxEngine.EntityInterface

{
    public global::FrooxEngine.SyncRef<global::FrooxEngine.IAudioStream> Source { get => Source_Element.Data; set => Source_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.SyncRef<global::FrooxEngine.IAudioStream>>, global::FrooxEngine.SyncRef<global::FrooxEngine.IAudioStream>> Source_Element = new();
public global::FrooxEngine.IField<global::System.Int32> Bitrate { get => Bitrate_Element.Data; set => Bitrate_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Int32>>, global::FrooxEngine.IField<global::System.Int32>> Bitrate_Element = new();
public global::FrooxEngine.IField<global::System.Single> Volume { get => Volume_Element.Data; set => Volume_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Single>>, global::FrooxEngine.IField<global::System.Single>> Volume_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> Spatialize { get => Spatialize_Element.Data; set => Spatialize_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Boolean>>, global::FrooxEngine.IField<global::System.Boolean>> Spatialize_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Source", Source_Element.ToLinkReference(context));
members.Add("Bitrate", Bitrate_Element.ToLinkReference(context));
members.Add("Volume", Volume_Element.ToLinkReference(context));
members.Add("Spatialize", Spatialize_Element.ToLinkReference(context));
}

}
}
