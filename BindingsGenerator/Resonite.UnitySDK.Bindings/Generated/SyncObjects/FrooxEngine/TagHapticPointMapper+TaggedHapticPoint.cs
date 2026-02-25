
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TagHapticPointMapper+TaggedHapticPoint
// Generated on: středa 25. února 2026 16:13:09
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
    public partial class TagHapticPointMapper
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TagHapticPointMapper+TaggedHapticPoint")]
public partial class TaggedHapticPoint : global::FrooxEngine.SyncObject

{
    public global::System.String HapticTag;
public global::FrooxEngine.Slot HapticPointRoot;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("HapticTag", HapticTag.ToResoniteLinkField());
members.Add("HapticPointRoot", HapticPointRoot.ToResoniteReference(context));
}

}
            }
}
