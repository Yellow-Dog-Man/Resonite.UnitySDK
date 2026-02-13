
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ModelExportable
// Generated on: pátek 13. února 2026 23:23:16
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ModelExportable")]
public partial class ModelExportable : global::FrooxEngine.Component, global::FrooxEngine.IExportable

{
    public global::FrooxEngine.Slot Root;
public System.Collections.Generic.List<global::FrooxEngine.Component> OnlyComponents;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Root", new ResoniteLink.Reference() { });
members.Add("OnlyComponents", new ResoniteLink.SyncList()
{
    Elements = OnlyComponents.ConvertList(m => new ResoniteLink.Reference() { })
});
}

}
}
