
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TextDisplayInterface
// Generated on: čtvrtek 19. února 2026 8:00:33
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TextDisplayInterface")]
public partial class TextDisplayInterface : global::FrooxEngine.EntityInterface

{
    public global::FrooxEngine.IField<global::System.String> Heading;
public global::FrooxEngine.IField<global::System.String> Text;
public global::FrooxEngine.IField<global::System.Boolean> RTF;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Heading", Heading.ToResoniteReference(context));
members.Add("Text", Text.ToResoniteReference(context));
members.Add("RTF", RTF.ToResoniteReference(context));
}

}
}
