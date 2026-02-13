
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TrackerSettings
// Generated on: pátek 13. února 2026 5:52:37
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TrackerSettings")]
public partial class TrackerSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.TrackerSettings>

{
    public global::System.Boolean UseTrackers;
public System.Collections.Generic.List<global::FrooxEngine.TrackerSettings.Tracker> Trackers;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("UseTrackers", UseTrackers.ToResoniteLinkField());
members.Add("Trackers", new ResoniteLink.SyncList()
{
    Elements = Trackers.Select(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() }).ToList<ResoniteLink.Member>()
});
}

}
}
