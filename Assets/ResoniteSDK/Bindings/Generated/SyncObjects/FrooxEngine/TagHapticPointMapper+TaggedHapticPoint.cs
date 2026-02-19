
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TagHapticPointMapper+TaggedHapticPoint
// Generated on: čtvrtek 19. února 2026 7:58:58
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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
