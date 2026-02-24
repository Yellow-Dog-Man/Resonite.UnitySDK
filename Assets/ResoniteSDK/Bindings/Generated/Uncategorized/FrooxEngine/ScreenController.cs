
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ScreenController
// Generated on: úterý 24. února 2026 18:18:57
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TransitionSpeed", TransitionSpeed.ToResoniteLinkField());
members.Add("PointerController", PointerController.ToResoniteReference(context));
members.Add("ActiveTargetting", ActiveTargetting.ToResoniteReference(context));
members.Add("Head", Head.ToResoniteReference(context));
members.Add("LeftHand", LeftHand.ToResoniteReference(context));
members.Add("RightHand", RightHand.ToResoniteReference(context));
members.Add("_previousTargetting", _previousTargetting.ToResoniteReference(context));
members.Add("_firstPerson", _firstPerson.ToResoniteReference(context));
members.Add("_thirdPerson", _thirdPerson.ToResoniteReference(context));
members.Add("_uiCamera", _uiCamera.ToResoniteReference(context));
members.Add("_freeformCamera", _freeformCamera.ToResoniteReference(context));
}

}
}
