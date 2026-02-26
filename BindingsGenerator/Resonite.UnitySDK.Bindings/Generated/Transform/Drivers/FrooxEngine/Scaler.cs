
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Scaler
// Generated on: čtvrtek 26. února 2026 10:04:41
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Scaler")]
public partial class Scaler : global::FrooxEngine.Component

{
    public UnityEngine.Vector3 ScaleOffset { get => ScaleOffset_Element.Data; set => ScaleOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> ScaleOffset_Element = new();
public UnityEngine.Vector3 ScaleMultiplier { get => ScaleMultiplier_Element.Data; set => ScaleMultiplier_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> ScaleMultiplier_Element = new();
public global::FrooxEngine.Slot ScaleSource { get => ScaleSource_Element.Data; set => ScaleSource_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> ScaleSource_Element = new();
public global::FrooxEngine.Scaler.Mode ScaleMode { get => ScaleMode_Element.Data; set => ScaleMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.Scaler.Mode>, global::FrooxEngine.Scaler.Mode> ScaleMode_Element = new();
public global::FrooxEngine.RootSpace ScaleSpace = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> scaleTarget { get => scaleTarget_Element.Data; set => scaleTarget_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> scaleTarget_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ScaleOffset", ScaleOffset_Element.Data.ToResoniteLinkField());
members.Add("ScaleMultiplier", ScaleMultiplier_Element.Data.ToResoniteLinkField());
members.Add("ScaleSource", ScaleSource_Element.Data.ToResoniteReference(context));
members.Add("ScaleMode", ScaleMode_Element.Data.ToResoniteLinkField());
members.Add("ScaleSpace", new ResoniteLink.SyncObject() { Members = ScaleSpace.CollectMembers(context) });
members.Add("scaleTarget", scaleTarget_Element.Data.ToResoniteReference(context));
}

}
}
