
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WorldCaptureThumbnailSource
// Generated on: čtvrtek 19. února 2026 8:00:34
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
