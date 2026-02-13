
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DynamicVisemeDriver+TargetDriver
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DynamicVisemeDriver+TargetDriver")]
public partial class TargetDriver : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.IField<global::System.Single> Target;
public System.Collections.Generic.List<global::FrooxEngine.DynamicVisemeDriver.VisemeSource> Sources;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Target", new ResoniteLink.Reference() { });
members.Add("Sources", new ResoniteLink.SyncList()
{
    Elements = Sources.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() })
});
}

}
            }
}
