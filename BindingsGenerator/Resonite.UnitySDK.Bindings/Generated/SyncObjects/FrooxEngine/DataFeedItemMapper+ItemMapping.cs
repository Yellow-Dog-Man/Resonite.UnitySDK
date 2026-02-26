
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DataFeedItemMapper+ItemMapping
// Generated on: čtvrtek 26. února 2026 15:09:01
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    public partial class DataFeedItemMapper
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DataFeedItemMapper+ItemMapping")]
public partial class ItemMapping : global::FrooxEngine.SyncObject

{
    public System.String MatchingType { get => MatchingType_Element.Data; set => MatchingType_Element.Data = value; }
public Field<global::FrooxEngine.SyncType, System.String> MatchingType_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncTypeList, System.String, Field<global::FrooxEngine.SyncType, System.String>> GenericReplacementTypes = new();
public global::FrooxEngine.FeedItemInterface Template { get => Template_Element.Data; set => Template_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.FeedItemInterface>, global::FrooxEngine.FeedItemInterface> Template_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MatchingType", MatchingType_Element.ToLinkField(context));
members.Add("GenericReplacementTypes", GenericReplacementTypes.ToLinkList(context, m => m.ToLinkField(context)));
members.Add("Template", Template_Element.ToLinkReference(context));
}

}
            }
}
