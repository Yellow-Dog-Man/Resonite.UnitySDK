
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ParentableChainBone<>
// Generated on: pátek 14. srpna 2026 21:57:42
// Resonite version: 2026.8.12.1196
// Resonite Link Version: 0.13.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ParentableChainBone<>")]
public partial class ParentableChainBone<T> : global::FrooxEngine.ChainBone
	where T : global::FrooxEngine.ParentableChainBone<T>, new()

{
    public global::FrooxEngine.ChainBone ParentBone { get => ParentBone_Element.Data; set => ParentBone_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ChainBone>, global::FrooxEngine.ChainBone> ParentBone_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ParentBone", ParentBone_Element.ToLinkReference(context));
}

}
}
