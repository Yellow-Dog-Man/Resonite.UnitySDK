
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.HyperlinkDisplayInterface
// Generated on: středa 25. února 2026 16:14:47
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
    public global::FrooxEngine.IField<System.Uri> Url;
public global::FrooxEngine.IField<global::System.String> UrlString;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Url", Url.ToResoniteReference(context));
members.Add("UrlString", UrlString.ToResoniteReference(context));
}

}
}
