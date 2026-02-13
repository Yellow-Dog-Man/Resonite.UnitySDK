
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyTextField
// Generated on: pátek 13. února 2026 23:23:11
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyTextField")]
public partial class LegacyTextField : global::FrooxEngine.LegacyFieldBase, global::FrooxEngine.ITextField

{
    public global::System.Boolean IsEnabled;
public global::FrooxEngine.TextRenderer _hintTextRenderer;
public global::FrooxEngine.IField<UnityEngine.Vector2> _hintTextBounds;
public global::FrooxEngine.IField<global::System.Boolean> _hintTextEnabled;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("IsEnabled", IsEnabled.ToResoniteLinkField());
members.Add("_hintTextRenderer", new ResoniteLink.Reference() { });
members.Add("_hintTextBounds", new ResoniteLink.Reference() { });
members.Add("_hintTextEnabled", new ResoniteLink.Reference() { });
}

}
}
