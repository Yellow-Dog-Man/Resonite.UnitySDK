
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.HandPoser+Finger
// Generated on: pondělí 2. března 2026 17:53:38
// Resonite version: 2026.3.2.1000
// Resonite Link Version: 1.0.0.0
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
