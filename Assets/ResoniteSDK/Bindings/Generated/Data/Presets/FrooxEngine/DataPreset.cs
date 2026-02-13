
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DataPreset
// Generated on: pátek 13. února 2026 23:21:39
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DataPreset")]
public partial class DataPreset : global::FrooxEngine.Component, global::FrooxEngine.ICustomInspector, global::FrooxEngine.IButtonPressReceiver

{
    public global::System.Boolean IsActive;
public System.Collections.Generic.List<global::FrooxEngine.IDataPresetEntry> Entries;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("IsActive", IsActive.ToResoniteLinkField());
members.Add("Entries", new ResoniteLink.SyncList()
{
    Elements = Entries.ConvertList(m => new ResoniteLink.Reference() { })
});
}

}
}
