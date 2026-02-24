
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.NoticeDisplayInterface
// Generated on: úterý 24. února 2026 18:20:34
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.NoticeDisplayInterface")]
public partial class NoticeDisplayInterface : global::FrooxEngine.EntityInterface

{
    public global::FrooxEngine.IField<global::System.String> Heading;
public global::FrooxEngine.IField<System.Uri> Icon;
public global::FrooxEngine.IField<global::System.String> Text;
public global::FrooxEngine.IField<UnityEngine.Color> Color;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Heading", Heading.ToResoniteReference(context));
members.Add("Icon", Icon.ToResoniteReference(context));
members.Add("Text", Text.ToResoniteReference(context));
members.Add("Color", Color.ToResoniteReference(context));
}

}
}
