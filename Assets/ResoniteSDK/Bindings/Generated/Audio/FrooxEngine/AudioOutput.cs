
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioOutput
// Generated on: čtvrtek 19. února 2026 7:58:54
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioOutput")]
public partial class AudioOutput : global::FrooxEngine.Component

{
    public global::System.Single Volume;
public global::FrooxEngine.IWorldAudioDataSource Source;
public global::System.Single SpatialBlend;
public global::System.Boolean Spatialize;
public global::System.Single SpatializationStartDistance;
public global::System.Single SpatializationTransitionRange;
public global::System.Single DopplerLevel;
public global::System.Single Pitch;
public global::System.Nullable<global::System.Boolean> Global;
public global::Awwdio.AudioRolloffCurve RolloffMode;
public global::System.Single MinDistance;
public global::System.Single MaxDistance;
public global::System.Int32 Priority;
public global::FrooxEngine.AudioTypeGroup AudioTypeGroup;
public global::FrooxEngine.AudioDistanceSpace DistanceSpace;
public global::System.Single MinScale;
public global::System.Single MaxScale;
public global::System.Boolean IgnoreAudioEffects;
public System.Collections.Generic.List<global::FrooxEngine.AudioListener> ExcludedListeners;
public System.Collections.Generic.List<global::FrooxEngine.User> excludedUsers;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Volume", Volume.ToResoniteLinkField());
members.Add("Source", Source.ToResoniteReference(context));
members.Add("SpatialBlend", SpatialBlend.ToResoniteLinkField());
members.Add("Spatialize", Spatialize.ToResoniteLinkField());
members.Add("SpatializationStartDistance", SpatializationStartDistance.ToResoniteLinkField());
members.Add("SpatializationTransitionRange", SpatializationTransitionRange.ToResoniteLinkField());
members.Add("DopplerLevel", DopplerLevel.ToResoniteLinkField());
members.Add("Pitch", Pitch.ToResoniteLinkField());
members.Add("Global", Global.ToResoniteLinkField());
members.Add("RolloffMode", RolloffMode.ToResoniteLinkField());
members.Add("MinDistance", MinDistance.ToResoniteLinkField());
members.Add("MaxDistance", MaxDistance.ToResoniteLinkField());
members.Add("Priority", Priority.ToResoniteLinkField());
members.Add("AudioTypeGroup", AudioTypeGroup.ToResoniteLinkField());
members.Add("DistanceSpace", DistanceSpace.ToResoniteLinkField());
members.Add("MinScale", MinScale.ToResoniteLinkField());
members.Add("MaxScale", MaxScale.ToResoniteLinkField());
members.Add("IgnoreAudioEffects", IgnoreAudioEffects.ToResoniteLinkField());
members.Add("ExcludedListeners", new ResoniteLink.SyncList()
{
    Elements = ExcludedListeners.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("excludedUsers", new ResoniteLink.SyncList()
{
    Elements = excludedUsers.ConvertList(m => m.ToResoniteReference(context))
});
}

}
}
