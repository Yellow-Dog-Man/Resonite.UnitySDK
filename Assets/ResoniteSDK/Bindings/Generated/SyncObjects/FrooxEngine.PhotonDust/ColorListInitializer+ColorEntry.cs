
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.ColorListInitializer+ColorEntry
// Generated on: pátek 13. února 2026 23:23:05
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.PhotonDust
{
    public partial class ColorListInitializer
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.ColorListInitializer+ColorEntry")]
public partial class ColorEntry : global::FrooxEngine.SyncObject

{
    public UnityEngine.ColorX Color;
public global::System.Single Weight;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Color", Color.ToResoniteLinkField());
members.Add("Weight", Weight.ToResoniteLinkField());
}

}
            }
}
