
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractiveCameraUserControl
// Generated on: pátek 6. března 2026 14:19:09
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InteractiveCameraUserControl")]
public partial class InteractiveCameraUserControl : global::FrooxEngine.LegacyCanvasPanel

{
    public global::FrooxEngine.InteractiveCameraControl Control { get => Control_Element.Data; set => Control_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.InteractiveCameraControl>, global::FrooxEngine.InteractiveCameraControl> Control_Element = new();
public global::FrooxEngine.Slot _uiRoot { get => _uiRoot_Element.Data; set => _uiRoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _uiRoot_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Control", Control_Element.ToLinkReference(context));
members.Add("_uiRoot", _uiRoot_Element.ToLinkReference(context));
}

}
}
