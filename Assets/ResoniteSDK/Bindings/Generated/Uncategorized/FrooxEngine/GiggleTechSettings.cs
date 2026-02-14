
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GiggleTechSettings
// Generated on: sobota 14. února 2026 8:58:44
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GiggleTechSettings")]
public partial class GiggleTechSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.GiggleTechSettings>

{
    public System.Collections.Generic.List<global::FrooxEngine.GiggleTechSettings.Device> Devices;
public global::System.String GigglePuckIP;
public global::System.Boolean IsGigglePuckValid;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Devices", new ResoniteLink.SyncList()
{
    Elements = Devices.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("GigglePuckIP", GigglePuckIP.ToResoniteLinkField());
members.Add("IsGigglePuckValid", IsGigglePuckValid.ToResoniteLinkField());
}

}
}
