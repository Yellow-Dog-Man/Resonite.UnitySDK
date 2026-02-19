
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AxisAligner
// Generated on: čtvrtek 19. února 2026 8:00:23
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AxisAligner")]
public partial class AxisAligner : global::FrooxEngine.AutoAddChildrenBase

{
    public global::FrooxEngine.AxisAligner.AxisDir Direction;
public global::FrooxEngine.AxisAligner.Align GlobalAxisXAlign;
public global::FrooxEngine.AxisAligner.Align GlobalAxisYAlign;
public global::FrooxEngine.AxisAligner.Align GlobalAxisZAlign;
public global::FrooxEngine.AxisAligner.Align ElementAxisXAlign;
public global::FrooxEngine.AxisAligner.Align ElementAxisYAlign;
public global::FrooxEngine.AxisAligner.Align ElementAxisZAlign;
public global::System.Single Separation;
public System.Collections.Generic.List<global::FrooxEngine.IBounded> ExcludeList;
public System.Collections.Generic.List<global::FrooxEngine.AxisAligner.Target> _targets;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Direction", Direction.ToResoniteLinkField());
members.Add("GlobalAxisXAlign", GlobalAxisXAlign.ToResoniteLinkField());
members.Add("GlobalAxisYAlign", GlobalAxisYAlign.ToResoniteLinkField());
members.Add("GlobalAxisZAlign", GlobalAxisZAlign.ToResoniteLinkField());
members.Add("ElementAxisXAlign", ElementAxisXAlign.ToResoniteLinkField());
members.Add("ElementAxisYAlign", ElementAxisYAlign.ToResoniteLinkField());
members.Add("ElementAxisZAlign", ElementAxisZAlign.ToResoniteLinkField());
members.Add("Separation", Separation.ToResoniteLinkField());
members.Add("ExcludeList", new ResoniteLink.SyncList()
{
    Elements = ExcludeList.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("_targets", new ResoniteLink.SyncList()
{
    Elements = _targets.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}
