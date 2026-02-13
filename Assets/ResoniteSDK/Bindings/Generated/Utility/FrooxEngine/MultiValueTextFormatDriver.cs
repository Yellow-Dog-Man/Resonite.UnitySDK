
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MultiValueTextFormatDriver
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MultiValueTextFormatDriver")]
public partial class MultiValueTextFormatDriver : global::FrooxEngine.Component

{
    public System.Collections.Generic.List<global::FrooxEngine.IField> Sources;
public global::System.String Format;
public global::FrooxEngine.IField<global::System.String> Text;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Sources", new ResoniteLink.SyncList()
{
    Elements = Sources.Select(m => new ResoniteLink.Reference() { }).ToList<ResoniteLink.Member>()
});
members.Add("Format", Format.ToResoniteLinkField());
members.Add("Text", new ResoniteLink.Reference() { });
}

}
}
