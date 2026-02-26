
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DynamicVisemeDriver+VisemeSource
// Generated on: čtvrtek 26. února 2026 12:28:03
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
    public partial class DynamicVisemeDriver
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DynamicVisemeDriver+VisemeSource")]
public partial class VisemeSource : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.Viseme Viseme { get => Viseme_Element.Data; set => Viseme_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.Viseme>, global::FrooxEngine.Viseme> Viseme_Element = new();
public global::System.Single Influence { get => Influence_Element.Data; set => Influence_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Influence_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Viseme", Viseme_Element.ToLinkField(context));
members.Add("Influence", Influence_Element.ToLinkField(context));
}

}
            }
}
