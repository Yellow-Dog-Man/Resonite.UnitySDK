
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ButtonStringAppend
// Generated on: čtvrtek 26. února 2026 15:07:57
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ButtonStringAppend")]
public partial class ButtonStringAppend : global::FrooxEngine.Component, global::FrooxEngine.IButtonPressReceiver

{
    public global::FrooxEngine.IField<global::System.String> TargetString { get => TargetString_Element.Data; set => TargetString_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> TargetString_Element = new();
public global::System.String AppendString { get => AppendString_Element.Data; set => AppendString_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> AppendString_Element = new();
public global::System.Boolean AppendInFront { get => AppendInFront_Element.Data; set => AppendInFront_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AppendInFront_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetString", TargetString_Element.ToLinkReference(context));
members.Add("AppendString", AppendString_Element.ToLinkField(context));
members.Add("AppendInFront", AppendInFront_Element.ToLinkField(context));
}

}
}
