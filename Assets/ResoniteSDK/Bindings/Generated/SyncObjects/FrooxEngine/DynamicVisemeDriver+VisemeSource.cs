
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DynamicVisemeDriver+VisemeSource
// Generated on: sobota 14. února 2026 8:58:33
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
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
    public global::FrooxEngine.Viseme Viseme;
public global::System.Single Influence;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Viseme", Viseme.ToResoniteLinkField());
members.Add("Influence", Influence.ToResoniteLinkField());
}

}
            }
}
