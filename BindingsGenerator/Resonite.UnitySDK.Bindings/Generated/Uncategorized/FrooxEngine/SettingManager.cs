
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SettingManager
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SettingManager")]
public partial class SettingManager : global::FrooxEngine.Component

{
    public global::System.String OwnerId { get => OwnerId_Element.Data; set => OwnerId_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> OwnerId_Element = new();
public global::FrooxEngine.SettingManager SupressedBy { get => SupressedBy_Element.Data; set => SupressedBy_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.SettingManager>, global::FrooxEngine.SettingManager> SupressedBy_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OwnerId", OwnerId_Element.Data.ToResoniteLinkField());
members.Add("SupressedBy", SupressedBy_Element.Data.ToResoniteReference(context));
}

}
}
