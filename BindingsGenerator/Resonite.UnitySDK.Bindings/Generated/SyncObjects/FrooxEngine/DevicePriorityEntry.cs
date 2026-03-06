
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DevicePriorityEntry
// Generated on: pátek 6. března 2026 14:19:07
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DevicePriorityEntry")]
public partial class DevicePriorityEntry : global::FrooxEngine.PriorityEntry<global::System.String>

{
    public global::System.String DeviceName { get => DeviceName_Element.Data; set => DeviceName_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> DeviceName_Element = new();
public global::System.Boolean Allowed { get => Allowed_Element.Data; set => Allowed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Allowed_Element = new();
public global::System.Boolean IsConnected { get => IsConnected_Element.Data; set => IsConnected_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsConnected_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DeviceName", DeviceName_Element.ToLinkField(context));
members.Add("Allowed", Allowed_Element.ToLinkField(context));
members.Add("IsConnected", IsConnected_Element.ToLinkField(context));
}

}
}
