
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DataPreset
// Generated on: sobota 14. února 2026 8:57:04
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DataPreset")]
public partial class DataPreset : global::FrooxEngine.Component, global::FrooxEngine.ICustomInspector, global::FrooxEngine.IButtonPressReceiver

{
    public global::System.Boolean IsActive;
public System.Collections.Generic.List<global::FrooxEngine.IDataPresetEntry> Entries;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IsActive", IsActive.ToResoniteLinkField());
members.Add("Entries", new ResoniteLink.SyncList()
{
    Elements = Entries.ConvertList(m => m.ToResoniteReference(context))
});
}

}
}
