
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyAudioOutputDopplerAdapter
// Generated on: sobota 14. února 2026 8:58:45
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyAudioOutputDopplerAdapter")]
public partial class LegacyAudioOutputDopplerAdapter : global::FrooxEngine.FieldAdapter<global::System.Single>

{
    public global::FrooxEngine.IField<global::System.Single> SpatialBlend;
public global::FrooxEngine.IField<global::System.Boolean> Spatialize;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SpatialBlend", SpatialBlend.ToResoniteReference(context));
members.Add("Spatialize", Spatialize.ToResoniteReference(context));
}

}
}
