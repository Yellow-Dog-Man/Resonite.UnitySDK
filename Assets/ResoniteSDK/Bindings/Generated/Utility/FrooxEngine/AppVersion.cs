
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AppVersion
// Generated on: úterý 24. února 2026 18:20:33
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AppVersion")]
public partial class AppVersion : global::FrooxEngine.Component

{
    public global::System.String VersionNumber;
public global::System.String VersionName;
public global::System.String FullVersionString;
public global::System.Int32 BuildYear;
public global::System.Int32 BuildMonth;
public global::System.Int32 BuildDay;
public global::System.Int32 BuildTimeOfDay;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("VersionNumber", VersionNumber.ToResoniteLinkField());
members.Add("VersionName", VersionName.ToResoniteLinkField());
members.Add("FullVersionString", FullVersionString.ToResoniteLinkField());
members.Add("BuildYear", BuildYear.ToResoniteLinkField());
members.Add("BuildMonth", BuildMonth.ToResoniteLinkField());
members.Add("BuildDay", BuildDay.ToResoniteLinkField());
members.Add("BuildTimeOfDay", BuildTimeOfDay.ToResoniteLinkField());
}

}
}
