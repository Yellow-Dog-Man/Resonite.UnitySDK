
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FingerPoseModifier+FingerOffsets
// Generated on: pátek 13. února 2026 23:23:20
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
    public partial class FingerPoseModifier
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FingerPoseModifier+FingerOffsets")]
public partial class FingerOffsets : global::FrooxEngine.SyncObject

{
    public global::System.Single ThumbCurlOffset;
public global::System.Single IndexCurlOffset;
public global::System.Single MiddleCurlOffset;
public global::System.Single RingCurlOffset;
public global::System.Single PinkyCurlOffset;
public global::System.Single ThumbSplayOffset;
public global::System.Single IndexSplayOffset;
public global::System.Single MiddleSplayOffset;
public global::System.Single RingSplayOffset;
public global::System.Single PinkySplayOffset;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ThumbCurlOffset", ThumbCurlOffset.ToResoniteLinkField());
members.Add("IndexCurlOffset", IndexCurlOffset.ToResoniteLinkField());
members.Add("MiddleCurlOffset", MiddleCurlOffset.ToResoniteLinkField());
members.Add("RingCurlOffset", RingCurlOffset.ToResoniteLinkField());
members.Add("PinkyCurlOffset", PinkyCurlOffset.ToResoniteLinkField());
members.Add("ThumbSplayOffset", ThumbSplayOffset.ToResoniteLinkField());
members.Add("IndexSplayOffset", IndexSplayOffset.ToResoniteLinkField());
members.Add("MiddleSplayOffset", MiddleSplayOffset.ToResoniteLinkField());
members.Add("RingSplayOffset", RingSplayOffset.ToResoniteLinkField());
members.Add("PinkySplayOffset", PinkySplayOffset.ToResoniteLinkField());
}

}
            }
}
