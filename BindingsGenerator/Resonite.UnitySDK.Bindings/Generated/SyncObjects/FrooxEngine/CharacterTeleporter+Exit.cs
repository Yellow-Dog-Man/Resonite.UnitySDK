
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CharacterTeleporter+Exit
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
    public partial class CharacterTeleporter
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CharacterTeleporter+Exit")]
public partial class Exit : global::FrooxEngine.SyncObject

{
    public global::System.Single Weight { get => Weight_Element.Data; set => Weight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Weight_Element = new();
public global::FrooxEngine.Slot TeleportExit { get => TeleportExit_Element.Data; set => TeleportExit_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> TeleportExit_Element = new();
public global::FrooxEngine.Slot ParentAfterTeleport { get => ParentAfterTeleport_Element.Data; set => ParentAfterTeleport_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> ParentAfterTeleport_Element = new();
public global::System.Boolean TransformRotation { get => TransformRotation_Element.Data; set => TransformRotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> TransformRotation_Element = new();
public global::System.Boolean TransformScale { get => TransformScale_Element.Data; set => TransformScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> TransformScale_Element = new();
public global::System.Boolean RelativeExitPoint { get => RelativeExitPoint_Element.Data; set => RelativeExitPoint_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> RelativeExitPoint_Element = new();
public global::FrooxEngine.IPointGenerator RandomExitPointGenerator { get => RandomExitPointGenerator_Element.Data; set => RandomExitPointGenerator_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IPointGenerator>, global::FrooxEngine.IPointGenerator> RandomExitPointGenerator_Element = new();
public global::System.Nullable<UnityEngine.Vector3> TeleportExitVelocity { get => TeleportExitVelocity_Element.Data; set => TeleportExitVelocity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<UnityEngine.Vector3>>, global::System.Nullable<UnityEngine.Vector3>> TeleportExitVelocity_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Weight", Weight_Element.ToLinkField(context));
members.Add("TeleportExit", TeleportExit_Element.ToLinkReference(context));
members.Add("ParentAfterTeleport", ParentAfterTeleport_Element.ToLinkReference(context));
members.Add("TransformRotation", TransformRotation_Element.ToLinkField(context));
members.Add("TransformScale", TransformScale_Element.ToLinkField(context));
members.Add("RelativeExitPoint", RelativeExitPoint_Element.ToLinkField(context));
members.Add("RandomExitPointGenerator", RandomExitPointGenerator_Element.ToLinkReference(context));
members.Add("TeleportExitVelocity", TeleportExitVelocity_Element.ToLinkField(context));
}

}
            }
}
