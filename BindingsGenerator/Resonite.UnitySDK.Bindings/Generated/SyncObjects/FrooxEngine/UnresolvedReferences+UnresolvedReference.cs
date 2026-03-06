
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UnresolvedReferences+UnresolvedReference
// Generated on: pátek 6. března 2026 14:19:11
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    public partial class UnresolvedReferences
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UnresolvedReferences+UnresolvedReference")]
public partial class UnresolvedReference : global::FrooxEngine.SyncObject

{
    public global::System.String Reference { get => Reference_Element.Data; set => Reference_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> Reference_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Reference", Reference_Element.ToLinkField(context));
}

}
            }
}
