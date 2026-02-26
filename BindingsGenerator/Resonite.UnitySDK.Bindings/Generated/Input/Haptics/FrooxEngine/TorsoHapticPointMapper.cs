
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TorsoHapticPointMapper
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TorsoHapticPointMapper")]
public partial class TorsoHapticPointMapper : global::FrooxEngine.BoneChainHapticPointMapper

{
    public global::System.Single LowerWidth { get => LowerWidth_Element.Data; set => LowerWidth_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> LowerWidth_Element = new();
public global::System.Single UpperWidth { get => UpperWidth_Element.Data; set => UpperWidth_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> UpperWidth_Element = new();
public global::System.Single FrontOffset { get => FrontOffset_Element.Data; set => FrontOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FrontOffset_Element = new();
public global::System.Single BackOffset { get => BackOffset_Element.Data; set => BackOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> BackOffset_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LowerWidth", LowerWidth_Element.ToLinkField(context));
members.Add("UpperWidth", UpperWidth_Element.ToLinkField(context));
members.Add("FrontOffset", FrontOffset_Element.ToLinkField(context));
members.Add("BackOffset", BackOffset_Element.ToLinkField(context));
}

}
}
