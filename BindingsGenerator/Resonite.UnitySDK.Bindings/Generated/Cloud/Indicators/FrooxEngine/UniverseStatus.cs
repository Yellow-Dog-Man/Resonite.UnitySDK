
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UniverseStatus
// Generated on: čtvrtek 26. února 2026 12:26:52
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UniverseStatus")]
public partial class UniverseStatus : global::FrooxEngine.Component

{
    public global::System.String UniverseId { get => UniverseId_Element.Data; set => UniverseId_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> UniverseId_Element = new();
public global::System.String UniverseName { get => UniverseName_Element.Data; set => UniverseName_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> UniverseName_Element = new();
public global::System.String PrimaryGroupId { get => PrimaryGroupId_Element.Data; set => PrimaryGroupId_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> PrimaryGroupId_Element = new();
public global::System.Boolean InUniverse { get => InUniverse_Element.Data; set => InUniverse_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> InUniverse_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UniverseId", UniverseId_Element.ToLinkField(context));
members.Add("UniverseName", UniverseName_Element.ToLinkField(context));
members.Add("PrimaryGroupId", PrimaryGroupId_Element.ToLinkField(context));
members.Add("InUniverse", InUniverse_Element.ToLinkField(context));
}

}
}
