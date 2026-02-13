
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TextExportable
// Generated on: pátek 13. února 2026 5:51:05
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TextExportable")]
public partial class TextExportable : global::FrooxEngine.Component, global::FrooxEngine.IExportable

{
    public global::FrooxEngine.IValue<global::System.String> TextSource;
public global::System.String Extension;
public global::System.String Description;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TextSource", new ResoniteLink.Reference() { });
members.Add("Extension", Extension.ToResoniteLinkField());
members.Add("Description", Description.ToResoniteLinkField());
}

}
}
