
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ScreenController
// Generated on: pátek 13. února 2026 5:51:44
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ScreenController")]
public partial class ScreenController : global::FrooxEngine.UserRootComponent, global::FrooxEngine.IInputUpdateReceiver

{
    public global::System.Single TransitionSpeed;
public global::FrooxEngine.PointerInteractionController PointerController;
public global::FrooxEngine.IViewTargettingController ActiveTargetting;
public global::FrooxEngine.HeadSimulator Head;
public global::FrooxEngine.HandSimulator LeftHand;
public global::FrooxEngine.HandSimulator RightHand;
public global::FrooxEngine.IViewTargettingController _previousTargetting;
public global::FrooxEngine.FirstPersonTargettingController _firstPerson;
public global::FrooxEngine.ThirdPersonTargettingController _thirdPerson;
public global::FrooxEngine.UI_TargettingController _uiCamera;
public global::FrooxEngine.FreeformTargettingController _freeformCamera;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TransitionSpeed", TransitionSpeed.ToResoniteLinkField());
members.Add("PointerController", new ResoniteLink.Reference() { });
members.Add("ActiveTargetting", new ResoniteLink.Reference() { });
members.Add("Head", new ResoniteLink.Reference() { });
members.Add("LeftHand", new ResoniteLink.Reference() { });
members.Add("RightHand", new ResoniteLink.Reference() { });
members.Add("_previousTargetting", new ResoniteLink.Reference() { });
members.Add("_firstPerson", new ResoniteLink.Reference() { });
members.Add("_thirdPerson", new ResoniteLink.Reference() { });
members.Add("_uiCamera", new ResoniteLink.Reference() { });
members.Add("_freeformCamera", new ResoniteLink.Reference() { });
}

}
}
