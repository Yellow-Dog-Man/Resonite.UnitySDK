
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ScreenController
// Generated on: čtvrtek 26. února 2026 15:08:29
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ScreenController")]
public partial class ScreenController : global::FrooxEngine.UserRootComponent, global::FrooxEngine.IInputUpdateReceiver

{
    public global::System.Single TransitionSpeed { get => TransitionSpeed_Element.Data; set => TransitionSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> TransitionSpeed_Element = new();
public global::FrooxEngine.PointerInteractionController PointerController { get => PointerController_Element.Data; set => PointerController_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.PointerInteractionController>, global::FrooxEngine.PointerInteractionController> PointerController_Element = new();
public global::FrooxEngine.IViewTargettingController ActiveTargetting { get => ActiveTargetting_Element.Data; set => ActiveTargetting_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IViewTargettingController>, global::FrooxEngine.IViewTargettingController> ActiveTargetting_Element = new();
public global::FrooxEngine.HeadSimulator Head { get => Head_Element.Data; set => Head_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.HeadSimulator>, global::FrooxEngine.HeadSimulator> Head_Element = new();
public global::FrooxEngine.HandSimulator LeftHand { get => LeftHand_Element.Data; set => LeftHand_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.HandSimulator>, global::FrooxEngine.HandSimulator> LeftHand_Element = new();
public global::FrooxEngine.HandSimulator RightHand { get => RightHand_Element.Data; set => RightHand_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.HandSimulator>, global::FrooxEngine.HandSimulator> RightHand_Element = new();
public global::FrooxEngine.IViewTargettingController _previousTargetting { get => _previousTargetting_Element.Data; set => _previousTargetting_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IViewTargettingController>, global::FrooxEngine.IViewTargettingController> _previousTargetting_Element = new();
public global::FrooxEngine.FirstPersonTargettingController _firstPerson { get => _firstPerson_Element.Data; set => _firstPerson_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.FirstPersonTargettingController>, global::FrooxEngine.FirstPersonTargettingController> _firstPerson_Element = new();
public global::FrooxEngine.ThirdPersonTargettingController _thirdPerson { get => _thirdPerson_Element.Data; set => _thirdPerson_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ThirdPersonTargettingController>, global::FrooxEngine.ThirdPersonTargettingController> _thirdPerson_Element = new();
public global::FrooxEngine.UI_TargettingController _uiCamera { get => _uiCamera_Element.Data; set => _uiCamera_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UI_TargettingController>, global::FrooxEngine.UI_TargettingController> _uiCamera_Element = new();
public global::FrooxEngine.FreeformTargettingController _freeformCamera { get => _freeformCamera_Element.Data; set => _freeformCamera_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.FreeformTargettingController>, global::FrooxEngine.FreeformTargettingController> _freeformCamera_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TransitionSpeed", TransitionSpeed_Element.ToLinkField(context));
members.Add("PointerController", PointerController_Element.ToLinkReference(context));
members.Add("ActiveTargetting", ActiveTargetting_Element.ToLinkReference(context));
members.Add("Head", Head_Element.ToLinkReference(context));
members.Add("LeftHand", LeftHand_Element.ToLinkReference(context));
members.Add("RightHand", RightHand_Element.ToLinkReference(context));
members.Add("_previousTargetting", _previousTargetting_Element.ToLinkReference(context));
members.Add("_firstPerson", _firstPerson_Element.ToLinkReference(context));
members.Add("_thirdPerson", _thirdPerson_Element.ToLinkReference(context));
members.Add("_uiCamera", _uiCamera_Element.ToLinkReference(context));
members.Add("_freeformCamera", _freeformCamera_Element.ToLinkReference(context));
}

}
}
