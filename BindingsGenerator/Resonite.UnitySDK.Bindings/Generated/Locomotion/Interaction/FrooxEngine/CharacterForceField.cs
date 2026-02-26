
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CharacterForceField
// Generated on: čtvrtek 26. února 2026 12:26:56
// Resonite version: 2026.2.26.702
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
    public UnityEngine.Vector3 Force { get => Force_Element.Data; set => Force_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Force_Element = new();
public global::FrooxEngine.CharacterForceField.Mode ForceMode { get => ForceMode_Element.Data; set => ForceMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.CharacterForceField.Mode>, global::FrooxEngine.CharacterForceField.Mode> ForceMode_Element = new();
public global::FrooxEngine.CharacterForceField.Space ForceSpace { get => ForceSpace_Element.Data; set => ForceSpace_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.CharacterForceField.Space>, global::FrooxEngine.CharacterForceField.Space> ForceSpace_Element = new();
public global::System.Single RadialForceRadius { get => RadialForceRadius_Element.Data; set => RadialForceRadius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RadialForceRadius_Element = new();
public global::FrooxEngine.RootSpace ForceSlotSpace = new();
public global::System.Single MinActivationVelocity { get => MinActivationVelocity_Element.Data; set => MinActivationVelocity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinActivationVelocity_Element = new();
public global::System.Single MaxForceVelocity { get => MaxForceVelocity_Element.Data; set => MaxForceVelocity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxForceVelocity_Element = new();
public global::System.Single HoldJumpMaxForceVelocity { get => HoldJumpMaxForceVelocity_Element.Data; set => HoldJumpMaxForceVelocity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HoldJumpMaxForceVelocity_Element = new();
public global::System.Boolean PreseveDirectionAcrossPlane { get => PreseveDirectionAcrossPlane_Element.Data; set => PreseveDirectionAcrossPlane_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PreseveDirectionAcrossPlane_Element = new();
public global::System.Boolean IgnoreParentUser { get => IgnoreParentUser_Element.Data; set => IgnoreParentUser_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IgnoreParentUser_Element = new();
public global::System.Single NoJumpMultiplier { get => NoJumpMultiplier_Element.Data; set => NoJumpMultiplier_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NoJumpMultiplier_Element = new();
public global::System.Single HoldJumpMultiplier { get => HoldJumpMultiplier_Element.Data; set => HoldJumpMultiplier_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HoldJumpMultiplier_Element = new();
public global::System.Single MaxCharacterVelocity { get => MaxCharacterVelocity_Element.Data; set => MaxCharacterVelocity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxCharacterVelocity_Element = new();
public global::System.Single MinCharacterVelocity { get => MinCharacterVelocity_Element.Data; set => MinCharacterVelocity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinCharacterVelocity_Element = new();
public global::System.Single CharacterVelocityDampeningSpeed { get => CharacterVelocityDampeningSpeed_Element.Data; set => CharacterVelocityDampeningSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> CharacterVelocityDampeningSpeed_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Force", Force_Element.ToLinkField(context));
members.Add("ForceMode", ForceMode_Element.ToLinkField(context));
members.Add("ForceSpace", ForceSpace_Element.ToLinkField(context));
members.Add("RadialForceRadius", RadialForceRadius_Element.ToLinkField(context));
members.Add("ForceSlotSpace", ForceSlotSpace.ToLinkSyncObject(context));
members.Add("MinActivationVelocity", MinActivationVelocity_Element.ToLinkField(context));
members.Add("MaxForceVelocity", MaxForceVelocity_Element.ToLinkField(context));
members.Add("HoldJumpMaxForceVelocity", HoldJumpMaxForceVelocity_Element.ToLinkField(context));
members.Add("PreseveDirectionAcrossPlane", PreseveDirectionAcrossPlane_Element.ToLinkField(context));
members.Add("IgnoreParentUser", IgnoreParentUser_Element.ToLinkField(context));
members.Add("NoJumpMultiplier", NoJumpMultiplier_Element.ToLinkField(context));
members.Add("HoldJumpMultiplier", HoldJumpMultiplier_Element.ToLinkField(context));
members.Add("MaxCharacterVelocity", MaxCharacterVelocity_Element.ToLinkField(context));
members.Add("MinCharacterVelocity", MinCharacterVelocity_Element.ToLinkField(context));
members.Add("CharacterVelocityDampeningSpeed", CharacterVelocityDampeningSpeed_Element.ToLinkField(context));
}

}
}
