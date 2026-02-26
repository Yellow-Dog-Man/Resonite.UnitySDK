
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TrackerSettings
// Generated on: čtvrtek 26. února 2026 10:04:48
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
    public global::System.Boolean UseTrackers { get => UseTrackers_Element.Data; set => UseTrackers_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseTrackers_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.TrackerSettings.Tracker>, global::FrooxEngine.TrackerSettings.Tracker> Trackers = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UseTrackers", UseTrackers_Element.Data.ToResoniteLinkField());
members.Add("Trackers", new ResoniteLink.SyncList()
{
    Elements = Trackers.Data.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
