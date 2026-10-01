
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DebugSettings
// Generated on: pátek 14. srpna 2026 21:57:55
// Resonite version: 2026.8.12.1196
// Resonite Link Version: 0.13.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DebugSettings")]
public partial class DebugSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.DebugSettings>

{
    public global::System.Boolean DebugInputBindings { get => DebugInputBindings_Element.Data; set => DebugInputBindings_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DebugInputBindings_Element = new();
public global::System.Boolean ShowMediaMTXWindow { get => ShowMediaMTXWindow_Element.Data; set => ShowMediaMTXWindow_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ShowMediaMTXWindow_Element = new();
public global::System.Boolean UseProtonForMediaMTX { get => UseProtonForMediaMTX_Element.Data; set => UseProtonForMediaMTX_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseProtonForMediaMTX_Element = new();
public global::System.Boolean ForceSoftwareVideoEncoder { get => ForceSoftwareVideoEncoder_Element.Data; set => ForceSoftwareVideoEncoder_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ForceSoftwareVideoEncoder_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DebugInputBindings", DebugInputBindings_Element.ToLinkField(context));
members.Add("ShowMediaMTXWindow", ShowMediaMTXWindow_Element.ToLinkField(context));
members.Add("UseProtonForMediaMTX", UseProtonForMediaMTX_Element.ToLinkField(context));
members.Add("ForceSoftwareVideoEncoder", ForceSoftwareVideoEncoder_Element.ToLinkField(context));
}

}
}
