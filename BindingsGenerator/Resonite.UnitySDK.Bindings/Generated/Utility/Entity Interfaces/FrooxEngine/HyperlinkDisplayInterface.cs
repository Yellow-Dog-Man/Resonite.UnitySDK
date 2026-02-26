
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.HyperlinkDisplayInterface
// Generated on: čtvrtek 26. února 2026 10:04:50
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.HyperlinkDisplayInterface")]
public partial class HyperlinkDisplayInterface : global::FrooxEngine.EntityInterface

{
    public global::FrooxEngine.IField<System.Uri> Url { get => Url_Element.Data; set => Url_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<System.Uri>>, global::FrooxEngine.IField<System.Uri>> Url_Element = new();
public global::FrooxEngine.IField<global::System.String> UrlString { get => UrlString_Element.Data; set => UrlString_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> UrlString_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Url", Url_Element.Data.ToResoniteReference(context));
members.Add("UrlString", UrlString_Element.Data.ToResoniteReference(context));
}

}
}
