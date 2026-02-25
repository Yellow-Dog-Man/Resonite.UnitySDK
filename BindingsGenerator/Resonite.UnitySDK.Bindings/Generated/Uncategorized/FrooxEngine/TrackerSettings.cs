
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TrackerSettings
// Generated on: středa 25. února 2026 16:14:43
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TrackerSettings")]
public partial class TrackerSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.TrackerSettings>

{
    public global::System.Boolean UseTrackers;
public System.Collections.Generic.List<global::FrooxEngine.TrackerSettings.Tracker> Trackers;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UseTrackers", UseTrackers.ToResoniteLinkField());
members.Add("Trackers", new ResoniteLink.SyncList()
{
    Elements = Trackers.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
