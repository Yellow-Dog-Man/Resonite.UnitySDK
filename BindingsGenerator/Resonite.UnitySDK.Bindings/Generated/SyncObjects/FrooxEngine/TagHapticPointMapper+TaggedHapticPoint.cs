
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TagHapticPointMapper+TaggedHapticPoint
// Generated on: čtvrtek 26. února 2026 12:26:55
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
    public partial class TagHapticPointMapper
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TagHapticPointMapper+TaggedHapticPoint")]
public partial class TaggedHapticPoint : global::FrooxEngine.SyncObject

{
    public global::System.String HapticTag { get => HapticTag_Element.Data; set => HapticTag_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> HapticTag_Element = new();
public global::FrooxEngine.Slot HapticPointRoot { get => HapticPointRoot_Element.Data; set => HapticPointRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> HapticPointRoot_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("HapticTag", HapticTag_Element.ToLinkField(context));
members.Add("HapticPointRoot", HapticPointRoot_Element.ToLinkReference(context));
}

}
            }
}
