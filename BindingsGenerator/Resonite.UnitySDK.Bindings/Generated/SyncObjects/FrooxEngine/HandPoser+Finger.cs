
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.HandPoser+Finger
// Generated on: čtvrtek 26. února 2026 15:09:17
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
    public partial class HandPoser
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.HandPoser+Finger")]
public partial class Finger : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.HandPoser.FingerSegment Metacarpal = new();
public global::FrooxEngine.HandPoser.FingerSegment Proximal = new();
public global::FrooxEngine.HandPoser.FingerSegment Intermediate = new();
public global::FrooxEngine.HandPoser.FingerSegment Distal = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Metacarpal", Metacarpal.ToLinkSyncObject(context));
members.Add("Proximal", Proximal.ToLinkSyncObject(context));
members.Add("Intermediate", Intermediate.ToLinkSyncObject(context));
members.Add("Distal", Distal.ToLinkSyncObject(context));
}

}
            }
}
