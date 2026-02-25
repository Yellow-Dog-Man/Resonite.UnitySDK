
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyAudioOutputIgnoreReverbAdapter
// Generated on: středa 25. února 2026 16:14:40
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyAudioOutputIgnoreReverbAdapter")]
public partial class LegacyAudioOutputIgnoreReverbAdapter : global::FrooxEngine.FieldAdapter<global::System.Boolean>

{
    public global::FrooxEngine.IField<global::System.Boolean> Spatialize;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Spatialize", Spatialize.ToResoniteReference(context));
}

}
}
