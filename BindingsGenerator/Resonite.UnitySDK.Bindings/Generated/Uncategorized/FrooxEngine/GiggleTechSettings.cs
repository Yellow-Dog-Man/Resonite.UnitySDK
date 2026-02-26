
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GiggleTechSettings
// Generated on: čtvrtek 26. února 2026 12:28:11
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GiggleTechSettings")]
public partial class GiggleTechSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.GiggleTechSettings>

{
    public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.GiggleTechSettings.Device>, global::FrooxEngine.GiggleTechSettings.Device> Devices = new();
public global::System.String GigglePuckIP { get => GigglePuckIP_Element.Data; set => GigglePuckIP_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> GigglePuckIP_Element = new();
public global::System.Boolean IsGigglePuckValid { get => IsGigglePuckValid_Element.Data; set => IsGigglePuckValid_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsGigglePuckValid_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Devices", Devices.ToLinkList(context, m => m.ToLinkSyncObject(context)));
members.Add("GigglePuckIP", GigglePuckIP_Element.ToLinkField(context));
members.Add("IsGigglePuckValid", IsGigglePuckValid_Element.ToLinkField(context));
}

}
}
