
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UnresolvedReferences+UnresolvedReference
// Generated on: středa 25. února 2026 16:14:43
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
    public partial class UnresolvedReferences
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UnresolvedReferences+UnresolvedReference")]
public partial class UnresolvedReference : global::FrooxEngine.SyncObject

{
    public global::System.String Reference;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Reference", Reference.ToResoniteLinkField());
}

}
            }
}
