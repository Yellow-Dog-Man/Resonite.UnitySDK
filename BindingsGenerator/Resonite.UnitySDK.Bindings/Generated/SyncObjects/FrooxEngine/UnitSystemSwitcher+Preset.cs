
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UnitSystemSwitcher+Preset
// Generated on: středa 25. února 2026 16:13:07
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DefaultUnit", DefaultUnit.ToResoniteLinkField());
members.Add("FormatUnit", FormatUnit.ToResoniteLinkField());
members.Add("FormatNumber", FormatNumber.ToResoniteLinkField());
members.Add("CompoundFormatUnits", new ResoniteLink.SyncList()
{
    Elements = CompoundFormatUnits.ConvertList(m => m.ToResoniteLinkField())
});
members.Add("CompoundSeparator", CompoundSeparator.ToResoniteLinkField());
members.Add("CompoundOverrideNames", CompoundOverrideNames.ToResoniteLinkField());
members.Add("CompoundUseLongNames", CompoundUseLongNames.ToResoniteLinkField());
}

}
            }
}
