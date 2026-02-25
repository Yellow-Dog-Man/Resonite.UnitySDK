
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MultiValueTextFormatDriver
// Generated on: středa 25. února 2026 16:14:46
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MultiValueTextFormatDriver")]
public partial class MultiValueTextFormatDriver : global::FrooxEngine.Component

{
    public System.Collections.Generic.List<global::FrooxEngine.IField> Sources;
public global::System.String Format;
public global::FrooxEngine.IField<global::System.String> Text;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Sources", new ResoniteLink.SyncList()
{
    Elements = Sources.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("Format", Format.ToResoniteLinkField());
members.Add("Text", Text.ToResoniteReference(context));
}

}
}
