
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ObjectOrb
// Generated on: úterý 24. února 2026 18:20:26
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ObjectOrb")]
public partial class ObjectOrb : global::FrooxEngine.Component

{
    public global::FrooxEngine.Slot PreviewRoot;
public global::FrooxEngine.Slot TemplateRoot;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PreviewRoot", PreviewRoot.ToResoniteReference(context));
members.Add("TemplateRoot", TemplateRoot.ToResoniteReference(context));
}

}
}
