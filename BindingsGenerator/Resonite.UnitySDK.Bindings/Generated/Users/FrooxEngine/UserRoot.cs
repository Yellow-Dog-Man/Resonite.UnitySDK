
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserRoot
// Generated on: čtvrtek 26. února 2026 10:04:06
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UserRoot")]
public partial class UserRoot : global::FrooxEngine.Component

{
    public global::FrooxEngine.IRenderSettingsSource RenderSettings { get => RenderSettings_Element.Data; set => RenderSettings_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IRenderSettingsSource>, global::FrooxEngine.IRenderSettingsSource> RenderSettings_Element = new();
public global::FrooxEngine.ScreenController ScreenController { get => ScreenController_Element.Data; set => ScreenController_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ScreenController>, global::FrooxEngine.ScreenController> ScreenController_Element = new();
public global::FrooxEngine.Slot OverrideRoot { get => OverrideRoot_Element.Data; set => OverrideRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> OverrideRoot_Element = new();
public global::FrooxEngine.Slot OverrideView { get => OverrideView_Element.Data; set => OverrideView_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> OverrideView_Element = new();
public global::FrooxEngine.AudioListener PrimaryListener { get => PrimaryListener_Element.Data; set => PrimaryListener_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.AudioListener>, global::FrooxEngine.AudioListener> PrimaryListener_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("RenderSettings", RenderSettings_Element.Data.ToResoniteReference(context));
members.Add("ScreenController", ScreenController_Element.Data.ToResoniteReference(context));
members.Add("OverrideRoot", OverrideRoot_Element.Data.ToResoniteReference(context));
members.Add("OverrideView", OverrideView_Element.Data.ToResoniteReference(context));
members.Add("PrimaryListener", PrimaryListener_Element.Data.ToResoniteReference(context));
}

}
}
