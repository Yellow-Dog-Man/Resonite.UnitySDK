
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ButtonStringErase
// Generated on: čtvrtek 26. února 2026 12:26:53
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ButtonStringErase")]
public partial class ButtonStringErase : global::FrooxEngine.Component, global::FrooxEngine.IButtonPressReceiver

{
    public global::FrooxEngine.IField<global::System.String> TargetString { get => TargetString_Element.Data; set => TargetString_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> TargetString_Element = new();
public global::System.Int32 Count { get => Count_Element.Data; set => Count_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Count_Element = new();
public global::System.Boolean EraseFromBeginning { get => EraseFromBeginning_Element.Data; set => EraseFromBeginning_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> EraseFromBeginning_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetString", TargetString_Element.ToLinkReference(context));
members.Add("Count", Count_Element.ToLinkField(context));
members.Add("EraseFromBeginning", EraseFromBeginning_Element.ToLinkField(context));
}

}
}
