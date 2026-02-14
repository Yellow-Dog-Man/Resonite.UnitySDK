
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LocomotionController
// Generated on: sobota 14. února 2026 8:57:07
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LocomotionController")]
public partial class LocomotionController : global::FrooxEngine.UserRootComponent

{
    public global::System.Boolean ScalingEnabled;
public System.Collections.Generic.List<global::FrooxEngine.Component> SupressSources;
public System.Collections.Generic.List<global::FrooxEngine.Component> InputSupressSources;
public System.Collections.Generic.List<global::FrooxEngine.ILocomotionModule> LocomotionModules;
public global::System.Int32 ActiveModuleIndex;
public global::System.Boolean FindUserPreferredModule;
public global::FrooxEngine.ICollider _currentGroundCollider;
public global::FrooxEngine.ICollider _lastGroundCollider;
public System.Collections.Generic.List<global::FrooxEngine.Slot> _parentHierarchy;
public global::FrooxEngine.CharacterController _dummyCharacterController;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ScalingEnabled", ScalingEnabled.ToResoniteLinkField());
members.Add("SupressSources", new ResoniteLink.SyncList()
{
    Elements = SupressSources.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("InputSupressSources", new ResoniteLink.SyncList()
{
    Elements = InputSupressSources.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("LocomotionModules", new ResoniteLink.SyncList()
{
    Elements = LocomotionModules.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("ActiveModuleIndex", ActiveModuleIndex.ToResoniteLinkField());
members.Add("FindUserPreferredModule", FindUserPreferredModule.ToResoniteLinkField());
members.Add("_currentGroundCollider", _currentGroundCollider.ToResoniteReference(context));
members.Add("_lastGroundCollider", _lastGroundCollider.ToResoniteReference(context));
members.Add("_parentHierarchy", new ResoniteLink.SyncList()
{
    Elements = _parentHierarchy.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("_dummyCharacterController", _dummyCharacterController.ToResoniteReference(context));
}

}
}
