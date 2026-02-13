
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.HyperlinkDisplayInterface
// Generated on: pátek 13. února 2026 5:52:40
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.HyperlinkDisplayInterface")]
public partial class HyperlinkDisplayInterface : global::FrooxEngine.EntityInterface

{
    public global::FrooxEngine.IField<System.Uri> Url;
public global::FrooxEngine.IField<global::System.String> UrlString;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Url", new ResoniteLink.Reference() { });
members.Add("UrlString", new ResoniteLink.Reference() { });
}

}
}
