
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioOutput
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioOutput")]
public partial class AudioOutput : global::FrooxEngine.Component

{
    public global::System.Single Volume { get => Volume_Element.Data; set => Volume_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Volume_Element = new();
public global::FrooxEngine.IWorldAudioDataSource Source { get => Source_Element.Data; set => Source_Element.Data = value; }
public Reference<global::FrooxEngine.DestroyRelayRef<global::FrooxEngine.IWorldAudioDataSource>, global::FrooxEngine.IWorldAudioDataSource> Source_Element = new();
public global::System.Single SpatialBlend { get => SpatialBlend_Element.Data; set => SpatialBlend_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SpatialBlend_Element = new();
public global::System.Boolean Spatialize { get => Spatialize_Element.Data; set => Spatialize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Spatialize_Element = new();
public global::System.Single SpatializationStartDistance { get => SpatializationStartDistance_Element.Data; set => SpatializationStartDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SpatializationStartDistance_Element = new();
public global::System.Single SpatializationTransitionRange { get => SpatializationTransitionRange_Element.Data; set => SpatializationTransitionRange_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SpatializationTransitionRange_Element = new();
public global::System.Single DopplerLevel { get => DopplerLevel_Element.Data; set => DopplerLevel_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> DopplerLevel_Element = new();
public global::System.Single Pitch { get => Pitch_Element.Data; set => Pitch_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Pitch_Element = new();
public global::System.Nullable<global::System.Boolean> Global { get => Global_Element.Data; set => Global_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Boolean>>, global::System.Nullable<global::System.Boolean>> Global_Element = new();
public global::Awwdio.AudioRolloffCurve RolloffMode { get => RolloffMode_Element.Data; set => RolloffMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Awwdio.AudioRolloffCurve>, global::Awwdio.AudioRolloffCurve> RolloffMode_Element = new();
public global::System.Single MinDistance { get => MinDistance_Element.Data; set => MinDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinDistance_Element = new();
public global::System.Single MaxDistance { get => MaxDistance_Element.Data; set => MaxDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxDistance_Element = new();
public global::System.Int32 Priority { get => Priority_Element.Data; set => Priority_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Priority_Element = new();
public global::FrooxEngine.AudioTypeGroup AudioTypeGroup { get => AudioTypeGroup_Element.Data; set => AudioTypeGroup_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.AudioTypeGroup>, global::FrooxEngine.AudioTypeGroup> AudioTypeGroup_Element = new();
public global::FrooxEngine.AudioDistanceSpace DistanceSpace { get => DistanceSpace_Element.Data; set => DistanceSpace_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.AudioDistanceSpace>, global::FrooxEngine.AudioDistanceSpace> DistanceSpace_Element = new();
public global::System.Single MinScale { get => MinScale_Element.Data; set => MinScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinScale_Element = new();
public global::System.Single MaxScale { get => MaxScale_Element.Data; set => MaxScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxScale_Element = new();
public global::System.Boolean IgnoreAudioEffects { get => IgnoreAudioEffects_Element.Data; set => IgnoreAudioEffects_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IgnoreAudioEffects_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.AudioListener>, global::FrooxEngine.AudioListener, Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.AudioListener>, global::FrooxEngine.AudioListener>> ExcludedListeners = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.User>, global::FrooxEngine.User, Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.User>, global::FrooxEngine.User>> excludedUsers = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Volume", Volume_Element.ToLinkField(context));
members.Add("Source", Source_Element.ToLinkReference(context));
members.Add("SpatialBlend", SpatialBlend_Element.ToLinkField(context));
members.Add("Spatialize", Spatialize_Element.ToLinkField(context));
members.Add("SpatializationStartDistance", SpatializationStartDistance_Element.ToLinkField(context));
members.Add("SpatializationTransitionRange", SpatializationTransitionRange_Element.ToLinkField(context));
members.Add("DopplerLevel", DopplerLevel_Element.ToLinkField(context));
members.Add("Pitch", Pitch_Element.ToLinkField(context));
members.Add("Global", Global_Element.ToLinkField(context));
members.Add("RolloffMode", RolloffMode_Element.ToLinkField(context));
members.Add("MinDistance", MinDistance_Element.ToLinkField(context));
members.Add("MaxDistance", MaxDistance_Element.ToLinkField(context));
members.Add("Priority", Priority_Element.ToLinkField(context));
members.Add("AudioTypeGroup", AudioTypeGroup_Element.ToLinkField(context));
members.Add("DistanceSpace", DistanceSpace_Element.ToLinkField(context));
members.Add("MinScale", MinScale_Element.ToLinkField(context));
members.Add("MaxScale", MaxScale_Element.ToLinkField(context));
members.Add("IgnoreAudioEffects", IgnoreAudioEffects_Element.ToLinkField(context));
members.Add("ExcludedListeners", ExcludedListeners.ToLinkList(context, m => m.ToLinkReference(context)));
members.Add("excludedUsers", excludedUsers.ToLinkList(context, m => m.ToLinkReference(context)));
}

}
}
