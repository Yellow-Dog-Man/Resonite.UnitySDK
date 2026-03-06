
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UI_TargettingController
// Generated on: pátek 6. března 2026 14:18:36
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UI_TargettingController")]
public partial class UI_TargettingController : global::FrooxEngine.FreeformCursorTargettingControllerBase<global::FrooxEngine.UICameraInputs>

{
    public global::FrooxEngine.IUIInterface Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IUIInterface>, global::FrooxEngine.IUIInterface> Target_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target_Element.ToLinkReference(context));
}

}
}
