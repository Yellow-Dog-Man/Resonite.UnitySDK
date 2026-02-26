
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AppVersionDriver
// Generated on: čtvrtek 26. února 2026 12:28:09
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AppVersionDriver")]
public partial class AppVersionDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<global::System.String> Text { get => Text_Element.Data; set => Text_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.String>, global::FrooxEngine.IField<global::System.String>> Text_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Text", Text_Element.ToLinkReference(context));
}

}
}
