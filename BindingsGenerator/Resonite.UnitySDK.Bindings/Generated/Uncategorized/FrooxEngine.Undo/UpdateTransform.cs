
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Undo.UpdateTransform
// Generated on: čtvrtek 26. února 2026 12:28:14
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.Undo
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Undo.UpdateTransform")]
public partial class UpdateTransform : global::FrooxEngine.Component, global::FrooxEngine.Undo.IUndoable

{
    public global::FrooxEngine.Slot Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> Target_Element = new();
public global::System.Boolean RestoreParent { get => RestoreParent_Element.Data; set => RestoreParent_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> RestoreParent_Element = new();
public global::System.Boolean RestorePosition { get => RestorePosition_Element.Data; set => RestorePosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> RestorePosition_Element = new();
public global::System.Boolean RestoreRotation { get => RestoreRotation_Element.Data; set => RestoreRotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> RestoreRotation_Element = new();
public global::System.Boolean RestoreScale { get => RestoreScale_Element.Data; set => RestoreScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> RestoreScale_Element = new();
public global::FrooxEngine.Slot ParentBefore { get => ParentBefore_Element.Data; set => ParentBefore_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> ParentBefore_Element = new();
public global::FrooxEngine.Slot ParentAfter { get => ParentAfter_Element.Data; set => ParentAfter_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> ParentAfter_Element = new();
public UnityEngine.Vector3 LocalPositionBefore { get => LocalPositionBefore_Element.Data; set => LocalPositionBefore_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> LocalPositionBefore_Element = new();
public UnityEngine.Quaternion LocalRotationBefore { get => LocalRotationBefore_Element.Data; set => LocalRotationBefore_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> LocalRotationBefore_Element = new();
public UnityEngine.Vector3 LocalScaleBefore { get => LocalScaleBefore_Element.Data; set => LocalScaleBefore_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> LocalScaleBefore_Element = new();
public UnityEngine.Vector3 GlobalPositionBefore { get => GlobalPositionBefore_Element.Data; set => GlobalPositionBefore_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> GlobalPositionBefore_Element = new();
public UnityEngine.Quaternion GlobalRotationBefore { get => GlobalRotationBefore_Element.Data; set => GlobalRotationBefore_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> GlobalRotationBefore_Element = new();
public UnityEngine.Vector3 GlobalScaleBefore { get => GlobalScaleBefore_Element.Data; set => GlobalScaleBefore_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> GlobalScaleBefore_Element = new();
public UnityEngine.Vector3 LocalPositionAfter { get => LocalPositionAfter_Element.Data; set => LocalPositionAfter_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> LocalPositionAfter_Element = new();
public UnityEngine.Quaternion LocalRotationAfter { get => LocalRotationAfter_Element.Data; set => LocalRotationAfter_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> LocalRotationAfter_Element = new();
public UnityEngine.Vector3 LocalScaleAfter { get => LocalScaleAfter_Element.Data; set => LocalScaleAfter_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> LocalScaleAfter_Element = new();
public UnityEngine.Vector3 GlobalPositionAfter { get => GlobalPositionAfter_Element.Data; set => GlobalPositionAfter_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> GlobalPositionAfter_Element = new();
public UnityEngine.Quaternion GlobalRotationAfter { get => GlobalRotationAfter_Element.Data; set => GlobalRotationAfter_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> GlobalRotationAfter_Element = new();
public UnityEngine.Vector3 GlobalScaleAfter { get => GlobalScaleAfter_Element.Data; set => GlobalScaleAfter_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> GlobalScaleAfter_Element = new();
public global::System.Boolean _performed { get => _performed_Element.Data; set => _performed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _performed_Element = new();
public global::System.String _description { get => _description_Element.Data; set => _description_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> _description_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target_Element.ToLinkReference(context));
members.Add("RestoreParent", RestoreParent_Element.ToLinkField(context));
members.Add("RestorePosition", RestorePosition_Element.ToLinkField(context));
members.Add("RestoreRotation", RestoreRotation_Element.ToLinkField(context));
members.Add("RestoreScale", RestoreScale_Element.ToLinkField(context));
members.Add("ParentBefore", ParentBefore_Element.ToLinkReference(context));
members.Add("ParentAfter", ParentAfter_Element.ToLinkReference(context));
members.Add("LocalPositionBefore", LocalPositionBefore_Element.ToLinkField(context));
members.Add("LocalRotationBefore", LocalRotationBefore_Element.ToLinkField(context));
members.Add("LocalScaleBefore", LocalScaleBefore_Element.ToLinkField(context));
members.Add("GlobalPositionBefore", GlobalPositionBefore_Element.ToLinkField(context));
members.Add("GlobalRotationBefore", GlobalRotationBefore_Element.ToLinkField(context));
members.Add("GlobalScaleBefore", GlobalScaleBefore_Element.ToLinkField(context));
members.Add("LocalPositionAfter", LocalPositionAfter_Element.ToLinkField(context));
members.Add("LocalRotationAfter", LocalRotationAfter_Element.ToLinkField(context));
members.Add("LocalScaleAfter", LocalScaleAfter_Element.ToLinkField(context));
members.Add("GlobalPositionAfter", GlobalPositionAfter_Element.ToLinkField(context));
members.Add("GlobalRotationAfter", GlobalRotationAfter_Element.ToLinkField(context));
members.Add("GlobalScaleAfter", GlobalScaleAfter_Element.ToLinkField(context));
members.Add("_performed", _performed_Element.ToLinkField(context));
members.Add("_description", _description_Element.ToLinkField(context));
}

}
}
