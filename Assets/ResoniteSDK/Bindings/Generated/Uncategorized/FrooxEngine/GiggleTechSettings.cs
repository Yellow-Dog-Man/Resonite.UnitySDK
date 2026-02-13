
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GiggleTechSettings
// Generated on: pátek 13. února 2026 23:23:14
// Resonite version: 2026.2.12.359
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Devices", new ResoniteLink.SyncList()
{
    Elements = Devices.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() })
});
members.Add("GigglePuckIP", GigglePuckIP.ToResoniteLinkField());
members.Add("IsGigglePuckValid", IsGigglePuckValid.ToResoniteLinkField());
}

}
}
