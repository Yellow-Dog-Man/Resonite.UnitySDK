
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LocalUserLiveStatus
// Generated on: čtvrtek 26. února 2026 12:28:16
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LocalUserLiveStatus")]
public partial class LocalUserLiveStatus : global::FrooxEngine.Component

{
    public global::System.Boolean IsLive { get => IsLive_Element.Data; set => IsLive_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> IsLive_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IsLive", IsLive_Element.ToLinkField(context));
}

}
}
