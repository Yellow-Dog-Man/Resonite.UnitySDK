
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ButtonDynamicImpulseTriggerWithReference<>+EventData
// Generated on: čtvrtek 26. února 2026 12:26:53
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
    public partial class ButtonDynamicImpulseTriggerWithReference<T>
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ButtonDynamicImpulseTriggerWithReference<>+EventData")]
public partial class EventData : global::FrooxEngine.SyncObject

{
    public global::System.String Tag { get => Tag_Element.Data; set => Tag_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> Tag_Element = new();
public T Reference { get => Reference_Element.Data; set => Reference_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<T>, T> Reference_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Tag", Tag_Element.ToLinkField(context));
members.Add("Reference", Reference_Element.ToLinkReference(context));
}

}
            }
}
