
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LerpingMultiClipPlayer+Track
// Generated on: čtvrtek 26. února 2026 15:07:57
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    public partial class LerpingMultiClipPlayer
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LerpingMultiClipPlayer+Track")]
public partial class Track : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> Clip { get => Clip_Element.Data; set => Clip_Element.Data = value; }
public Reference<global::FrooxEngine.AssetRef<global::FrooxEngine.AudioClip>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip>> Clip_Element = new();
public global::System.Single StartPosition { get => StartPosition_Element.Data; set => StartPosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> StartPosition_Element = new();
public global::System.Single EndPosition { get => EndPosition_Element.Data; set => EndPosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> EndPosition_Element = new();
public global::System.Single StartSpeed { get => StartSpeed_Element.Data; set => StartSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> StartSpeed_Element = new();
public global::System.Single EndSpeed { get => EndSpeed_Element.Data; set => EndSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> EndSpeed_Element = new();
public global::System.Single StartVolumeTransitionRatio { get => StartVolumeTransitionRatio_Element.Data; set => StartVolumeTransitionRatio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> StartVolumeTransitionRatio_Element = new();
public global::System.Single EndVolumeTransitionRatio { get => EndVolumeTransitionRatio_Element.Data; set => EndVolumeTransitionRatio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> EndVolumeTransitionRatio_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Clip", Clip_Element.ToLinkReference(context));
members.Add("StartPosition", StartPosition_Element.ToLinkField(context));
members.Add("EndPosition", EndPosition_Element.ToLinkField(context));
members.Add("StartSpeed", StartSpeed_Element.ToLinkField(context));
members.Add("EndSpeed", EndSpeed_Element.ToLinkField(context));
members.Add("StartVolumeTransitionRatio", StartVolumeTransitionRatio_Element.ToLinkField(context));
members.Add("EndVolumeTransitionRatio", EndVolumeTransitionRatio_Element.ToLinkField(context));
}

}
            }
}
