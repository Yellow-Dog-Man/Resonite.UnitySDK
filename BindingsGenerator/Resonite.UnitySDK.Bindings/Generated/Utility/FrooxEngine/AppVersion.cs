
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AppVersion
// Generated on: čtvrtek 26. února 2026 12:28:15
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AppVersion")]
public partial class AppVersion : global::FrooxEngine.Component

{
    public global::System.String VersionNumber { get => VersionNumber_Element.Data; set => VersionNumber_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> VersionNumber_Element = new();
public global::System.String VersionName { get => VersionName_Element.Data; set => VersionName_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> VersionName_Element = new();
public global::System.String FullVersionString { get => FullVersionString_Element.Data; set => FullVersionString_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> FullVersionString_Element = new();
public global::System.Int32 BuildYear { get => BuildYear_Element.Data; set => BuildYear_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> BuildYear_Element = new();
public global::System.Int32 BuildMonth { get => BuildMonth_Element.Data; set => BuildMonth_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> BuildMonth_Element = new();
public global::System.Int32 BuildDay { get => BuildDay_Element.Data; set => BuildDay_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> BuildDay_Element = new();
public global::System.Int32 BuildTimeOfDay { get => BuildTimeOfDay_Element.Data; set => BuildTimeOfDay_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> BuildTimeOfDay_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("VersionNumber", VersionNumber_Element.ToLinkField(context));
members.Add("VersionName", VersionName_Element.ToLinkField(context));
members.Add("FullVersionString", FullVersionString_Element.ToLinkField(context));
members.Add("BuildYear", BuildYear_Element.ToLinkField(context));
members.Add("BuildMonth", BuildMonth_Element.ToLinkField(context));
members.Add("BuildDay", BuildDay_Element.ToLinkField(context));
members.Add("BuildTimeOfDay", BuildTimeOfDay_Element.ToLinkField(context));
}

}
}
