
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ReferenceOptionDescriptionDriver<>+Option
// Generated on: pátek 13. února 2026 23:21:38
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
    public partial class ReferenceOptionDescriptionDriver<T>
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ReferenceOptionDescriptionDriver<>+Option")]
public partial class Option : global::FrooxEngine.SyncObject

{
    public T ReferenceTarget;
public global::System.String Label;
public UnityEngine.ColorX Color;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Sprite> Sprite;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ReferenceTarget", new ResoniteLink.Reference() { });
members.Add("Label", Label.ToResoniteLinkField());
members.Add("Color", Color.ToResoniteLinkField());
members.Add("Sprite", new ResoniteLink.Reference() { });
}

}
            }
}
