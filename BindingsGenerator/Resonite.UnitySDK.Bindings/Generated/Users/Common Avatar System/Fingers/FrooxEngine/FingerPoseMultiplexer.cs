
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FingerPoseMultiplexer
// Generated on: středa 25. února 2026 16:14:46
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FingerPoseMultiplexer")]
public partial class FingerPoseMultiplexer : global::FrooxEngine.FingerPoseProcessor

{
    public global::System.Int32 Index;
public global::System.Single InterpolationSpeed;
public System.Collections.Generic.List<global::FrooxEngine.IFingerPoseSourceComponent> Sources;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Index", Index.ToResoniteLinkField());
members.Add("InterpolationSpeed", InterpolationSpeed.ToResoniteLinkField());
members.Add("Sources", new ResoniteLink.SyncList()
{
    Elements = Sources.ConvertList(m => m.ToResoniteReference(context))
});
}

}
}
