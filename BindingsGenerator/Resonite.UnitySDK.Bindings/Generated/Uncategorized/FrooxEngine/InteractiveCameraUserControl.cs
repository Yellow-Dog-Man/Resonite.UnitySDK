
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractiveCameraUserControl
// Generated on: středa 25. února 2026 16:14:40
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InteractiveCameraUserControl")]
public partial class InteractiveCameraUserControl : global::FrooxEngine.LegacyCanvasPanel

{
    public global::FrooxEngine.InteractiveCameraControl Control;
public global::FrooxEngine.Slot _uiRoot;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Control", Control.ToResoniteReference(context));
members.Add("_uiRoot", _uiRoot.ToResoniteReference(context));
}

}
}
