
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TextExportable
// Generated on: sobota 14. února 2026 8:56:55
// Resonite version: 2026.2.14.493
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TextSource", TextSource.ToResoniteReference(context));
members.Add("Extension", Extension.ToResoniteLinkField());
members.Add("Description", Description.ToResoniteLinkField());
}

}
}
