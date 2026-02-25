
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LerpingMultiClipPlayer+Track
// Generated on: středa 25. února 2026 16:13:06
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
    public partial class LerpingMultiClipPlayer
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LerpingMultiClipPlayer+Track")]
public partial class Track : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.AudioClip> Clip;
public global::System.Single StartPosition;
public global::System.Single EndPosition;
public global::System.Single StartSpeed;
public global::System.Single EndSpeed;
public global::System.Single StartVolumeTransitionRatio;
public global::System.Single EndVolumeTransitionRatio;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Clip", Clip.ToResoniteReference(context));
members.Add("StartPosition", StartPosition.ToResoniteLinkField());
members.Add("EndPosition", EndPosition.ToResoniteLinkField());
members.Add("StartSpeed", StartSpeed.ToResoniteLinkField());
members.Add("EndSpeed", EndSpeed.ToResoniteLinkField());
members.Add("StartVolumeTransitionRatio", StartVolumeTransitionRatio.ToResoniteLinkField());
members.Add("EndVolumeTransitionRatio", EndVolumeTransitionRatio.ToResoniteLinkField());
}

}
            }
}
