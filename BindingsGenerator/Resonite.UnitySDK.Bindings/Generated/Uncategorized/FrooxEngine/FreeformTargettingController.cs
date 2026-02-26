
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FreeformTargettingController
// Generated on: čtvrtek 26. února 2026 12:27:26
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FreeformTargettingController")]
public partial class FreeformTargettingController : global::FrooxEngine.FreeformCursorTargettingControllerBase<global::FrooxEngine.FreeformCameraInputs>

{
    public global::FrooxEngine.Slot FocusTarget { get => FocusTarget_Element.Data; set => FocusTarget_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> FocusTarget_Element = new();
public UnityEngine.Vector3 FocusCenterPoint { get => FocusCenterPoint_Element.Data; set => FocusCenterPoint_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> FocusCenterPoint_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("FocusTarget", FocusTarget_Element.ToLinkReference(context));
members.Add("FocusCenterPoint", FocusCenterPoint_Element.ToLinkField(context));
}

}
}
