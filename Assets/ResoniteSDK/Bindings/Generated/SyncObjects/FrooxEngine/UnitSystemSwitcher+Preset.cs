
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UnitSystemSwitcher+Preset
// Generated on: pátek 13. února 2026 5:51:11
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
    public partial class UnitSystemSwitcher
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UnitSystemSwitcher+Preset")]
public partial class Preset : global::FrooxEngine.SyncObject

{
    public global::System.String DefaultUnit;
public global::System.String FormatUnit;
public global::System.String FormatNumber;
public System.Collections.Generic.List<global::System.String> CompoundFormatUnits;
public global::System.String CompoundSeparator;
public global::System.Boolean CompoundOverrideNames;
public global::System.Boolean CompoundUseLongNames;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("DefaultUnit", DefaultUnit.ToResoniteLinkField());
members.Add("FormatUnit", FormatUnit.ToResoniteLinkField());
members.Add("FormatNumber", FormatNumber.ToResoniteLinkField());
members.Add("CompoundFormatUnits", new ResoniteLink.SyncList()
{
    Elements = CompoundFormatUnits.Select(m => m.ToResoniteLinkField()).ToList<ResoniteLink.Member>()
});
members.Add("CompoundSeparator", CompoundSeparator.ToResoniteLinkField());
members.Add("CompoundOverrideNames", CompoundOverrideNames.ToResoniteLinkField());
members.Add("CompoundUseLongNames", CompoundUseLongNames.ToResoniteLinkField());
}

}
            }
}
