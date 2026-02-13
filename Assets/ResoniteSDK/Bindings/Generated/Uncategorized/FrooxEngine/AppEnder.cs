
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AppEnder
// Generated on: pátek 13. února 2026 23:23:12
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AppEnder")]
public partial class AppEnder : global::FrooxEngine.Component

{
    public global::FrooxEngine.AppEnder.EndMode Mode;
public global::System.Boolean ChangesSaved;
public global::FrooxEngine.TextRenderer _text;
public global::FrooxEngine.IField<UnityEngine.ColorX> _textColor;
public global::FrooxEngine.IField<UnityEngine.ColorX> _outlineColor;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Mode", Mode.ToResoniteLinkField());
members.Add("ChangesSaved", ChangesSaved.ToResoniteLinkField());
members.Add("_text", new ResoniteLink.Reference() { });
members.Add("_textColor", new ResoniteLink.Reference() { });
members.Add("_outlineColor", new ResoniteLink.Reference() { });
}

}
}
