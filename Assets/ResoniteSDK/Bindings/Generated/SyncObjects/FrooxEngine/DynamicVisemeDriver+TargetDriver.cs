
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DynamicVisemeDriver+TargetDriver
// Generated on: čtvrtek 19. února 2026 8:00:19
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DynamicVisemeDriver+TargetDriver")]
public partial class TargetDriver : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.IField<global::System.Single> Target;
public System.Collections.Generic.List<global::FrooxEngine.DynamicVisemeDriver.VisemeSource> Sources;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target.ToResoniteReference(context));
members.Add("Sources", new ResoniteLink.SyncList()
{
    Elements = Sources.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
            }
}
