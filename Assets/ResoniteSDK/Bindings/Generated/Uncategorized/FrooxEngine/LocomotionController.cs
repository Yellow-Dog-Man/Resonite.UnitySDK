
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LocomotionController
// Generated on: pátek 13. února 2026 5:51:14
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ScalingEnabled", ScalingEnabled.ToResoniteLinkField());
members.Add("SupressSources", new ResoniteLink.SyncList()
{
    Elements = SupressSources.Select(m => new ResoniteLink.Reference() { }).ToList<ResoniteLink.Member>()
});
members.Add("InputSupressSources", new ResoniteLink.SyncList()
{
    Elements = InputSupressSources.Select(m => new ResoniteLink.Reference() { }).ToList<ResoniteLink.Member>()
});
members.Add("LocomotionModules", new ResoniteLink.SyncList()
{
    Elements = LocomotionModules.Select(m => new ResoniteLink.Reference() { }).ToList<ResoniteLink.Member>()
});
members.Add("ActiveModuleIndex", ActiveModuleIndex.ToResoniteLinkField());
members.Add("FindUserPreferredModule", FindUserPreferredModule.ToResoniteLinkField());
members.Add("_currentGroundCollider", new ResoniteLink.Reference() { });
members.Add("_lastGroundCollider", new ResoniteLink.Reference() { });
members.Add("_parentHierarchy", new ResoniteLink.SyncList()
{
    Elements = _parentHierarchy.Select(m => new ResoniteLink.Reference() { }).ToList<ResoniteLink.Member>()
});
members.Add("_dummyCharacterController", new ResoniteLink.Reference() { });
}

}
}
