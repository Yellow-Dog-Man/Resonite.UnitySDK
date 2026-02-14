
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WorldCaptureThumbnailSource
// Generated on: sobota 14. února 2026 8:58:51
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.WorldCaptureThumbnailSource")]
public partial class WorldCaptureThumbnailSource : global::FrooxEngine.CaptureThumbnailSource, global::FrooxEngine.IWorldThumbnailSource

{
    public global::System.Boolean ExcludeUsersInCapture;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ExcludeUsersInCapture", ExcludeUsersInCapture.ToResoniteLinkField());
}

}
}
