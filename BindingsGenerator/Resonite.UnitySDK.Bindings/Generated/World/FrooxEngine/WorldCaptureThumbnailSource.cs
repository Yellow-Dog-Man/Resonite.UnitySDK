
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WorldCaptureThumbnailSource
// Generated on: čtvrtek 26. února 2026 15:09:18
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.WorldCaptureThumbnailSource")]
public partial class WorldCaptureThumbnailSource : global::FrooxEngine.CaptureThumbnailSource, global::FrooxEngine.IWorldThumbnailSource

{
    public global::System.Boolean ExcludeUsersInCapture { get => ExcludeUsersInCapture_Element.Data; set => ExcludeUsersInCapture_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ExcludeUsersInCapture_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ExcludeUsersInCapture", ExcludeUsersInCapture_Element.ToLinkField(context));
}

}
}
