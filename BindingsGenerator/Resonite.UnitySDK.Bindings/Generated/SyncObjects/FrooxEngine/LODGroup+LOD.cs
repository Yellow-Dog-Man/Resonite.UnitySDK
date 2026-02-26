
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LODGroup+LOD
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
    public partial class LODGroup
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LODGroup+LOD")]
public partial class LOD : global::FrooxEngine.SyncObject

{
    public global::System.Single ScreenRelativeTransitionHeight { get => ScreenRelativeTransitionHeight_Element.Data; set => ScreenRelativeTransitionHeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ScreenRelativeTransitionHeight_Element = new();
public global::System.Single FadeTransitionWidth { get => FadeTransitionWidth_Element.Data; set => FadeTransitionWidth_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FadeTransitionWidth_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncRelayList<global::FrooxEngine.MeshRenderer>, global::FrooxEngine.MeshRenderer, Field<global::FrooxEngine.RelayRef<global::FrooxEngine.MeshRenderer>, global::FrooxEngine.MeshRenderer>> Renderers = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ScreenRelativeTransitionHeight", ScreenRelativeTransitionHeight_Element.ToLinkField(context));
members.Add("FadeTransitionWidth", FadeTransitionWidth_Element.ToLinkField(context));
members.Add("Renderers", Renderers.ToLinkList(context, m => m.ToLinkReference(context)));
}

}
            }
}
