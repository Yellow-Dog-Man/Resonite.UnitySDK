
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractiveCameraControlAnchors
// Generated on: čtvrtek 26. února 2026 15:09:12
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InteractiveCameraControlAnchors")]
public partial class InteractiveCameraControlAnchors : global::FrooxEngine.LegacyCanvasPanel

{
    public global::FrooxEngine.Slot _uiRoot { get => _uiRoot_Element.Data; set => _uiRoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _uiRoot_Element = new();
public global::FrooxEngine.InteractiveCameraControl _cameraControl { get => _cameraControl_Element.Data; set => _cameraControl_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.InteractiveCameraControl>, global::FrooxEngine.InteractiveCameraControl> _cameraControl_Element = new();
public global::FrooxEngine.UIX.Text _noAnchorMessage { get => _noAnchorMessage_Element.Data; set => _noAnchorMessage_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _noAnchorMessage_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_uiRoot", _uiRoot_Element.ToLinkReference(context));
members.Add("_cameraControl", _cameraControl_Element.ToLinkReference(context));
members.Add("_noAnchorMessage", _noAnchorMessage_Element.ToLinkReference(context));
}

}
}
