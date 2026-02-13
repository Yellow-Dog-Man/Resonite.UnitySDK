
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TextDisplayInterface
// Generated on: pátek 13. února 2026 23:23:21
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TextDisplayInterface")]
public partial class TextDisplayInterface : global::FrooxEngine.EntityInterface

{
    public global::FrooxEngine.IField<global::System.String> Heading;
public global::FrooxEngine.IField<global::System.String> Text;
public global::FrooxEngine.IField<global::System.Boolean> RTF;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Heading", new ResoniteLink.Reference() { });
members.Add("Text", new ResoniteLink.Reference() { });
members.Add("RTF", new ResoniteLink.Reference() { });
}

}
}
