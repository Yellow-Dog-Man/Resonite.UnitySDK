
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractiveCameraControlAnchors
// Generated on: pátek 13. února 2026 5:52:33
// Resonite version: 2026.2.13.254
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("_uiRoot", new ResoniteLink.Reference() { });
members.Add("_cameraControl", new ResoniteLink.Reference() { });
members.Add("_noAnchorMessage", new ResoniteLink.Reference() { });
}

}
}
