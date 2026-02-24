
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DataFeedItemMapper+ItemMapping
// Generated on: úterý 24. února 2026 18:20:02
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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
    public System.String MatchingType;
public System.Collections.Generic.List<System.String> GenericReplacementTypes;
public global::FrooxEngine.FeedItemInterface Template;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MatchingType", MatchingType.ToResoniteLinkField());
members.Add("GenericReplacementTypes", new ResoniteLink.SyncList()
{
    Elements = GenericReplacementTypes.ConvertList(m => m.ToResoniteLinkField())
});
members.Add("Template", Template.ToResoniteReference(context));
}

}
            }
}
