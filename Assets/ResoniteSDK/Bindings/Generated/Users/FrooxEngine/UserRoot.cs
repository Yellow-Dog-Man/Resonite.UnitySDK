
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserRoot
// Generated on: sobota 14. února 2026 8:57:46
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UserRoot")]
public partial class UserRoot : global::FrooxEngine.Component

{
    public global::FrooxEngine.IRenderSettingsSource RenderSettings;
public global::FrooxEngine.ScreenController ScreenController;
public global::FrooxEngine.Slot OverrideRoot;
public global::FrooxEngine.Slot OverrideView;
public global::FrooxEngine.AudioListener PrimaryListener;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("RenderSettings", RenderSettings.ToResoniteReference(context));
members.Add("ScreenController", ScreenController.ToResoniteReference(context));
members.Add("OverrideRoot", OverrideRoot.ToResoniteReference(context));
members.Add("OverrideView", OverrideView.ToResoniteReference(context));
members.Add("PrimaryListener", PrimaryListener.ToResoniteReference(context));
}

}
}
