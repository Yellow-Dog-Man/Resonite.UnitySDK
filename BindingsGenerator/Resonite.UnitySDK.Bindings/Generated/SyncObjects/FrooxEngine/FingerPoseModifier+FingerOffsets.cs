
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FingerPoseModifier+FingerOffsets
// Generated on: čtvrtek 26. února 2026 12:28:15
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
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
    public global::System.Single ThumbCurlOffset { get => ThumbCurlOffset_Element.Data; set => ThumbCurlOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ThumbCurlOffset_Element = new();
public global::System.Single IndexCurlOffset { get => IndexCurlOffset_Element.Data; set => IndexCurlOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> IndexCurlOffset_Element = new();
public global::System.Single MiddleCurlOffset { get => MiddleCurlOffset_Element.Data; set => MiddleCurlOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MiddleCurlOffset_Element = new();
public global::System.Single RingCurlOffset { get => RingCurlOffset_Element.Data; set => RingCurlOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RingCurlOffset_Element = new();
public global::System.Single PinkyCurlOffset { get => PinkyCurlOffset_Element.Data; set => PinkyCurlOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> PinkyCurlOffset_Element = new();
public global::System.Single ThumbSplayOffset { get => ThumbSplayOffset_Element.Data; set => ThumbSplayOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ThumbSplayOffset_Element = new();
public global::System.Single IndexSplayOffset { get => IndexSplayOffset_Element.Data; set => IndexSplayOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> IndexSplayOffset_Element = new();
public global::System.Single MiddleSplayOffset { get => MiddleSplayOffset_Element.Data; set => MiddleSplayOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MiddleSplayOffset_Element = new();
public global::System.Single RingSplayOffset { get => RingSplayOffset_Element.Data; set => RingSplayOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RingSplayOffset_Element = new();
public global::System.Single PinkySplayOffset { get => PinkySplayOffset_Element.Data; set => PinkySplayOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> PinkySplayOffset_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ThumbCurlOffset", ThumbCurlOffset_Element.ToLinkField(context));
members.Add("IndexCurlOffset", IndexCurlOffset_Element.ToLinkField(context));
members.Add("MiddleCurlOffset", MiddleCurlOffset_Element.ToLinkField(context));
members.Add("RingCurlOffset", RingCurlOffset_Element.ToLinkField(context));
members.Add("PinkyCurlOffset", PinkyCurlOffset_Element.ToLinkField(context));
members.Add("ThumbSplayOffset", ThumbSplayOffset_Element.ToLinkField(context));
members.Add("IndexSplayOffset", IndexSplayOffset_Element.ToLinkField(context));
members.Add("MiddleSplayOffset", MiddleSplayOffset_Element.ToLinkField(context));
members.Add("RingSplayOffset", RingSplayOffset_Element.ToLinkField(context));
members.Add("PinkySplayOffset", PinkySplayOffset_Element.ToLinkField(context));
}

}
            }
}
