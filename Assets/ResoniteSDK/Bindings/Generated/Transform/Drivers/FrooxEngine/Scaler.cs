
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Scaler
// Generated on: sobota 14. února 2026 8:58:39
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Scaler")]
public partial class Scaler : global::FrooxEngine.Component

{
    public UnityEngine.Vector3 ScaleOffset;
public UnityEngine.Vector3 ScaleMultiplier;
public global::FrooxEngine.Slot ScaleSource;
public global::FrooxEngine.Scaler.Mode ScaleMode;
public global::FrooxEngine.RootSpace ScaleSpace;
public global::FrooxEngine.IField<UnityEngine.Vector3> scaleTarget;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ScaleOffset", ScaleOffset.ToResoniteLinkField());
members.Add("ScaleMultiplier", ScaleMultiplier.ToResoniteLinkField());
members.Add("ScaleSource", ScaleSource.ToResoniteReference(context));
members.Add("ScaleMode", ScaleMode.ToResoniteLinkField());
members.Add("ScaleSpace", new ResoniteLink.SyncObject() { Members = ScaleSpace.CollectMembers(context) });
members.Add("scaleTarget", scaleTarget.ToResoniteReference(context));
}

}
}
