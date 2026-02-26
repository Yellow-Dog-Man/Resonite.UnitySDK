
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.NoticeDisplayInterface
// Generated on: čtvrtek 26. února 2026 12:28:16
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.NoticeDisplayInterface")]
public partial class NoticeDisplayInterface : global::FrooxEngine.EntityInterface

{
    public global::FrooxEngine.IField<global::System.String> Heading { get => Heading_Element.Data; set => Heading_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> Heading_Element = new();
public global::FrooxEngine.IField<System.Uri> Icon { get => Icon_Element.Data; set => Icon_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<System.Uri>>, global::FrooxEngine.IField<System.Uri>> Icon_Element = new();
public global::FrooxEngine.IField<global::System.String> Text { get => Text_Element.Data; set => Text_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> Text_Element = new();
public global::FrooxEngine.IField<UnityEngine.Color> Color { get => Color_Element.Data; set => Color_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<UnityEngine.Color>>, global::FrooxEngine.IField<UnityEngine.Color>> Color_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Heading", Heading_Element.ToLinkReference(context));
members.Add("Icon", Icon_Element.ToLinkReference(context));
members.Add("Text", Text_Element.ToLinkReference(context));
members.Add("Color", Color_Element.ToLinkReference(context));
}

}
}
