
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.HandPoser+Finger
// Generated on: pátek 13. února 2026 23:23:20
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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
    public global::FrooxEngine.HandPoser.FingerSegment Metacarpal;
public global::FrooxEngine.HandPoser.FingerSegment Proximal;
public global::FrooxEngine.HandPoser.FingerSegment Intermediate;
public global::FrooxEngine.HandPoser.FingerSegment Distal;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Metacarpal", new ResoniteLink.SyncObject() { Members = Metacarpal.CollectMembers() });
members.Add("Proximal", new ResoniteLink.SyncObject() { Members = Proximal.CollectMembers() });
members.Add("Intermediate", new ResoniteLink.SyncObject() { Members = Intermediate.CollectMembers() });
members.Add("Distal", new ResoniteLink.SyncObject() { Members = Distal.CollectMembers() });
}

}
            }
}
