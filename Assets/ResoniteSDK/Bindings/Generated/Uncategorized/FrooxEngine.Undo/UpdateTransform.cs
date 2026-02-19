
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Undo.UpdateTransform
// Generated on: čtvrtek 19. února 2026 8:00:31
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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
    public global::FrooxEngine.Slot Target;
public global::System.Boolean RestoreParent;
public global::System.Boolean RestorePosition;
public global::System.Boolean RestoreRotation;
public global::System.Boolean RestoreScale;
public global::FrooxEngine.Slot ParentBefore;
public global::FrooxEngine.Slot ParentAfter;
public UnityEngine.Vector3 LocalPositionBefore;
public UnityEngine.Quaternion LocalRotationBefore;
public UnityEngine.Vector3 LocalScaleBefore;
public UnityEngine.Vector3 GlobalPositionBefore;
public UnityEngine.Quaternion GlobalRotationBefore;
public UnityEngine.Vector3 GlobalScaleBefore;
public UnityEngine.Vector3 LocalPositionAfter;
public UnityEngine.Quaternion LocalRotationAfter;
public UnityEngine.Vector3 LocalScaleAfter;
public UnityEngine.Vector3 GlobalPositionAfter;
public UnityEngine.Quaternion GlobalRotationAfter;
public UnityEngine.Vector3 GlobalScaleAfter;
public global::System.Boolean _performed;
public global::System.String _description;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target.ToResoniteReference(context));
members.Add("RestoreParent", RestoreParent.ToResoniteLinkField());
members.Add("RestorePosition", RestorePosition.ToResoniteLinkField());
members.Add("RestoreRotation", RestoreRotation.ToResoniteLinkField());
members.Add("RestoreScale", RestoreScale.ToResoniteLinkField());
members.Add("ParentBefore", ParentBefore.ToResoniteReference(context));
members.Add("ParentAfter", ParentAfter.ToResoniteReference(context));
members.Add("LocalPositionBefore", LocalPositionBefore.ToResoniteLinkField());
members.Add("LocalRotationBefore", LocalRotationBefore.ToResoniteLinkField());
members.Add("LocalScaleBefore", LocalScaleBefore.ToResoniteLinkField());
members.Add("GlobalPositionBefore", GlobalPositionBefore.ToResoniteLinkField());
members.Add("GlobalRotationBefore", GlobalRotationBefore.ToResoniteLinkField());
members.Add("GlobalScaleBefore", GlobalScaleBefore.ToResoniteLinkField());
members.Add("LocalPositionAfter", LocalPositionAfter.ToResoniteLinkField());
members.Add("LocalRotationAfter", LocalRotationAfter.ToResoniteLinkField());
members.Add("LocalScaleAfter", LocalScaleAfter.ToResoniteLinkField());
members.Add("GlobalPositionAfter", GlobalPositionAfter.ToResoniteLinkField());
members.Add("GlobalRotationAfter", GlobalRotationAfter.ToResoniteLinkField());
members.Add("GlobalScaleAfter", GlobalScaleAfter.ToResoniteLinkField());
members.Add("_performed", _performed.ToResoniteLinkField());
members.Add("_description", _description.ToResoniteLinkField());
}

}
}
