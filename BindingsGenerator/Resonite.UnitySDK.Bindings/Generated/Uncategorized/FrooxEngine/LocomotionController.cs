
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LocomotionController
// Generated on: čtvrtek 26. února 2026 10:03:40
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LocomotionController")]
public partial class LocomotionController : global::FrooxEngine.UserRootComponent

{
    public global::System.Boolean ScalingEnabled { get => ScalingEnabled_Element.Data; set => ScalingEnabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ScalingEnabled_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.Component>, global::FrooxEngine.Component, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Component>, global::FrooxEngine.Component>> SupressSources = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.Component>, global::FrooxEngine.Component, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Component>, global::FrooxEngine.Component>> InputSupressSources = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.ILocomotionModule>, global::FrooxEngine.ILocomotionModule, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ILocomotionModule>, global::FrooxEngine.ILocomotionModule>> LocomotionModules = new();
public global::System.Int32 ActiveModuleIndex { get => ActiveModuleIndex_Element.Data; set => ActiveModuleIndex_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> ActiveModuleIndex_Element = new();
public global::System.Boolean FindUserPreferredModule { get => FindUserPreferredModule_Element.Data; set => FindUserPreferredModule_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> FindUserPreferredModule_Element = new();
public global::FrooxEngine.ICollider _currentGroundCollider { get => _currentGroundCollider_Element.Data; set => _currentGroundCollider_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ICollider>, global::FrooxEngine.ICollider> _currentGroundCollider_Element = new();
public global::FrooxEngine.ICollider _lastGroundCollider { get => _lastGroundCollider_Element.Data; set => _lastGroundCollider_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ICollider>, global::FrooxEngine.ICollider> _lastGroundCollider_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.Slot>, global::FrooxEngine.Slot, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot>> _parentHierarchy = new();
public global::FrooxEngine.CharacterController _dummyCharacterController { get => _dummyCharacterController_Element.Data; set => _dummyCharacterController_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.CharacterController>, global::FrooxEngine.CharacterController> _dummyCharacterController_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ScalingEnabled", ScalingEnabled_Element.Data.ToResoniteLinkField());
members.Add("SupressSources", new ResoniteLink.SyncList()
{
    Elements = SupressSources.Data.ConvertList(m => m.Data.ToResoniteReference(context))
});
members.Add("InputSupressSources", new ResoniteLink.SyncList()
{
    Elements = InputSupressSources.Data.ConvertList(m => m.Data.ToResoniteReference(context))
});
members.Add("LocomotionModules", new ResoniteLink.SyncList()
{
    Elements = LocomotionModules.Data.ConvertList(m => m.Data.ToResoniteReference(context))
});
members.Add("ActiveModuleIndex", ActiveModuleIndex_Element.Data.ToResoniteLinkField());
members.Add("FindUserPreferredModule", FindUserPreferredModule_Element.Data.ToResoniteLinkField());
members.Add("_currentGroundCollider", _currentGroundCollider_Element.Data.ToResoniteReference(context));
members.Add("_lastGroundCollider", _lastGroundCollider_Element.Data.ToResoniteReference(context));
members.Add("_parentHierarchy", new ResoniteLink.SyncList()
{
    Elements = _parentHierarchy.Data.ConvertList(m => m.Data.ToResoniteReference(context))
});
members.Add("_dummyCharacterController", _dummyCharacterController_Element.Data.ToResoniteReference(context));
}

}
}
