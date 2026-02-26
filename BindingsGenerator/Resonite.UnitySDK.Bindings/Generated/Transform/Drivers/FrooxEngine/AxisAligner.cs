
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AxisAligner
// Generated on: čtvrtek 26. února 2026 15:09:07
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AxisAligner")]
public partial class AxisAligner : global::FrooxEngine.AutoAddChildrenBase

{
    public global::FrooxEngine.AxisAligner.AxisDir Direction { get => Direction_Element.Data; set => Direction_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.AxisAligner.AxisDir>, global::FrooxEngine.AxisAligner.AxisDir> Direction_Element = new();
public global::FrooxEngine.AxisAligner.Align GlobalAxisXAlign { get => GlobalAxisXAlign_Element.Data; set => GlobalAxisXAlign_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.AxisAligner.Align>, global::FrooxEngine.AxisAligner.Align> GlobalAxisXAlign_Element = new();
public global::FrooxEngine.AxisAligner.Align GlobalAxisYAlign { get => GlobalAxisYAlign_Element.Data; set => GlobalAxisYAlign_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.AxisAligner.Align>, global::FrooxEngine.AxisAligner.Align> GlobalAxisYAlign_Element = new();
public global::FrooxEngine.AxisAligner.Align GlobalAxisZAlign { get => GlobalAxisZAlign_Element.Data; set => GlobalAxisZAlign_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.AxisAligner.Align>, global::FrooxEngine.AxisAligner.Align> GlobalAxisZAlign_Element = new();
public global::FrooxEngine.AxisAligner.Align ElementAxisXAlign { get => ElementAxisXAlign_Element.Data; set => ElementAxisXAlign_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.AxisAligner.Align>, global::FrooxEngine.AxisAligner.Align> ElementAxisXAlign_Element = new();
public global::FrooxEngine.AxisAligner.Align ElementAxisYAlign { get => ElementAxisYAlign_Element.Data; set => ElementAxisYAlign_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.AxisAligner.Align>, global::FrooxEngine.AxisAligner.Align> ElementAxisYAlign_Element = new();
public global::FrooxEngine.AxisAligner.Align ElementAxisZAlign { get => ElementAxisZAlign_Element.Data; set => ElementAxisZAlign_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.AxisAligner.Align>, global::FrooxEngine.AxisAligner.Align> ElementAxisZAlign_Element = new();
public global::System.Single Separation { get => Separation_Element.Data; set => Separation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Separation_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.IBounded>, global::FrooxEngine.IBounded, Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IBounded>, global::FrooxEngine.IBounded>> ExcludeList = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.AxisAligner.Target>, global::FrooxEngine.AxisAligner.Target> _targets = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Direction", Direction_Element.ToLinkField(context));
members.Add("GlobalAxisXAlign", GlobalAxisXAlign_Element.ToLinkField(context));
members.Add("GlobalAxisYAlign", GlobalAxisYAlign_Element.ToLinkField(context));
members.Add("GlobalAxisZAlign", GlobalAxisZAlign_Element.ToLinkField(context));
members.Add("ElementAxisXAlign", ElementAxisXAlign_Element.ToLinkField(context));
members.Add("ElementAxisYAlign", ElementAxisYAlign_Element.ToLinkField(context));
members.Add("ElementAxisZAlign", ElementAxisZAlign_Element.ToLinkField(context));
members.Add("Separation", Separation_Element.ToLinkField(context));
members.Add("ExcludeList", ExcludeList.ToLinkList(context, m => m.ToLinkReference(context)));
members.Add("_targets", _targets.ToLinkList(context, m => m.ToLinkSyncObject(context)));
}

}
}
