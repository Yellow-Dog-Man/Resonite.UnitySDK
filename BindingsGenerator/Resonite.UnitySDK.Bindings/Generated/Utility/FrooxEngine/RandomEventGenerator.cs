
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RandomEventGenerator
// Generated on: čtvrtek 26. února 2026 10:04:50
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RandomEventGenerator")]
public partial class RandomEventGenerator : global::FrooxEngine.Component

{
    public global::System.Single MinInterval { get => MinInterval_Element.Data; set => MinInterval_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinInterval_Element = new();
public global::System.Single MaxInterval { get => MaxInterval_Element.Data; set => MaxInterval_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxInterval_Element = new();
public global::FrooxEngine.IPointGenerator RandomPointGenerator { get => RandomPointGenerator_Element.Data; set => RandomPointGenerator_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IPointGenerator>, global::FrooxEngine.IPointGenerator> RandomPointGenerator_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MinInterval", MinInterval_Element.Data.ToResoniteLinkField());
members.Add("MaxInterval", MaxInterval_Element.Data.ToResoniteLinkField());
members.Add("RandomPointGenerator", RandomPointGenerator_Element.Data.ToResoniteReference(context));
}

}
}
