
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractiveCameraControlAnchors
// Generated on: sobota 14. února 2026 8:58:44
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InteractiveCameraControlAnchors")]
public partial class InteractiveCameraControlAnchors : global::FrooxEngine.LegacyCanvasPanel

{
    public global::FrooxEngine.Slot _uiRoot;
public global::FrooxEngine.InteractiveCameraControl _cameraControl;
public global::FrooxEngine.UIX.Text _noAnchorMessage;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_uiRoot", _uiRoot.ToResoniteReference(context));
members.Add("_cameraControl", _cameraControl.ToResoniteReference(context));
members.Add("_noAnchorMessage", _noAnchorMessage.ToResoniteReference(context));
}

}
}
