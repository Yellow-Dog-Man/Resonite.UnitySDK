
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.HyperlinkDisplayInterface
// Generated on: pátek 6. března 2026 14:19:12
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
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
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<System.Uri>>, global::FrooxEngine.IField<System.Uri>> Url_Element = new();
public global::FrooxEngine.IField<global::System.String> UrlString { get => UrlString_Element.Data; set => UrlString_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> UrlString_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Url", Url_Element.ToLinkReference(context));
members.Add("UrlString", UrlString_Element.ToLinkReference(context));
}

}
}
