
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CharacterForceField
// Generated on: středa 25. února 2026 16:13:10
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CharacterForceField")]
public partial class CharacterForceField : global::FrooxEngine.CollisionListenerComponent

{
    public UnityEngine.Vector3 Force;
public global::FrooxEngine.CharacterForceField.Mode ForceMode;
public global::FrooxEngine.CharacterForceField.Space ForceSpace;
public global::System.Single RadialForceRadius;
public global::FrooxEngine.RootSpace ForceSlotSpace;
public global::System.Single MinActivationVelocity;
public global::System.Single MaxForceVelocity;
public global::System.Single HoldJumpMaxForceVelocity;
public global::System.Boolean PreseveDirectionAcrossPlane;
public global::System.Boolean IgnoreParentUser;
public global::System.Single NoJumpMultiplier;
public global::System.Single HoldJumpMultiplier;
public global::System.Single MaxCharacterVelocity;
public global::System.Single MinCharacterVelocity;
public global::System.Single CharacterVelocityDampeningSpeed;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Force", Force.ToResoniteLinkField());
members.Add("ForceMode", ForceMode.ToResoniteLinkField());
members.Add("ForceSpace", ForceSpace.ToResoniteLinkField());
members.Add("RadialForceRadius", RadialForceRadius.ToResoniteLinkField());
members.Add("ForceSlotSpace", new ResoniteLink.SyncObject() { Members = ForceSlotSpace.CollectMembers(context) });
members.Add("MinActivationVelocity", MinActivationVelocity.ToResoniteLinkField());
members.Add("MaxForceVelocity", MaxForceVelocity.ToResoniteLinkField());
members.Add("HoldJumpMaxForceVelocity", HoldJumpMaxForceVelocity.ToResoniteLinkField());
members.Add("PreseveDirectionAcrossPlane", PreseveDirectionAcrossPlane.ToResoniteLinkField());
members.Add("IgnoreParentUser", IgnoreParentUser.ToResoniteLinkField());
members.Add("NoJumpMultiplier", NoJumpMultiplier.ToResoniteLinkField());
members.Add("HoldJumpMultiplier", HoldJumpMultiplier.ToResoniteLinkField());
members.Add("MaxCharacterVelocity", MaxCharacterVelocity.ToResoniteLinkField());
members.Add("MinCharacterVelocity", MinCharacterVelocity.ToResoniteLinkField());
members.Add("CharacterVelocityDampeningSpeed", CharacterVelocityDampeningSpeed.ToResoniteLinkField());
}

}
}
