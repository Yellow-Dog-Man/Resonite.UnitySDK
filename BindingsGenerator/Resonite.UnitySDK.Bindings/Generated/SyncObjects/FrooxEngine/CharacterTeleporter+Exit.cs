
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CharacterTeleporter+Exit
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
    public partial class CharacterTeleporter
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CharacterTeleporter+Exit")]
public partial class Exit : global::FrooxEngine.SyncObject

{
    public global::System.Single Weight;
public global::FrooxEngine.Slot TeleportExit;
public global::FrooxEngine.Slot ParentAfterTeleport;
public global::System.Boolean TransformRotation;
public global::System.Boolean TransformScale;
public global::System.Boolean RelativeExitPoint;
public global::FrooxEngine.IPointGenerator RandomExitPointGenerator;
public global::System.Nullable<UnityEngine.Vector3> TeleportExitVelocity;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Weight", Weight.ToResoniteLinkField());
members.Add("TeleportExit", TeleportExit.ToResoniteReference(context));
members.Add("ParentAfterTeleport", ParentAfterTeleport.ToResoniteReference(context));
members.Add("TransformRotation", TransformRotation.ToResoniteLinkField());
members.Add("TransformScale", TransformScale.ToResoniteLinkField());
members.Add("RelativeExitPoint", RelativeExitPoint.ToResoniteLinkField());
members.Add("RandomExitPointGenerator", RandomExitPointGenerator.ToResoniteReference(context));
members.Add("TeleportExitVelocity", TeleportExitVelocity.ToResoniteLinkField());
}

}
            }
}
