
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VolumeMeter
// Generated on: čtvrtek 26. února 2026 12:26:57
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VolumeMeter")]
public partial class VolumeMeter : global::FrooxEngine.VolumeMeterBase

{
    public global::System.Single Volume { get => Volume_Element.Data; set => Volume_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> Volume_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Volume", Volume_Element.ToLinkField(context));
}

}
}
