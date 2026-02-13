
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DynamicVisemeDriver+VisemeSource
// Generated on: pátek 13. února 2026 23:23:04
// Resonite version: 2026.2.12.359
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Viseme", Viseme.ToResoniteLinkField());
members.Add("Influence", Influence.ToResoniteLinkField());
}

}
            }
}
