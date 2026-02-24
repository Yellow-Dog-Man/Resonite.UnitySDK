
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BooleanSwitcher
// Generated on: úterý 24. února 2026 18:20:13
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BooleanSwitcher")]
public partial class BooleanSwitcher : global::FrooxEngine.AutoAddChildrenBase, global::FrooxEngine.ICustomInspector

{
    public System.Collections.Generic.List<global::FrooxEngine.IField<global::System.Boolean>> Targets;
public global::System.Int32 ActiveIndex;
public global::FrooxEngine.BooleanSwitcher.Mode ActivationMode;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Targets", new ResoniteLink.SyncList()
{
    Elements = Targets.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("ActiveIndex", ActiveIndex.ToResoniteLinkField());
members.Add("ActivationMode", ActivationMode.ToResoniteLinkField());
}

}
}
