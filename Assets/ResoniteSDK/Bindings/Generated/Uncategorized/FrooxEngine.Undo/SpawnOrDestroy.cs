
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Undo.SpawnOrDestroy
// Generated on: sobota 14. února 2026 8:58:48
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.Undo
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Undo.SpawnOrDestroy")]
public partial class SpawnOrDestroy : global::FrooxEngine.Component, global::FrooxEngine.Undo.IUndoable

{
    public global::FrooxEngine.Worker Target;
public global::FrooxEngine.Slot TargetParent;
public global::FrooxEngine.Undo.SpawnOrDestroy.Mode _mode;
public global::System.Boolean _preserveAssets;
public global::System.Boolean _sendDestroyingEvents;
public System.Uri _savedObject;
public global::System.Boolean _isComponent;
public global::FrooxEngine.SavedReferenceTable _referenceTable;
public global::System.Boolean _isSaving;
public global::System.String _description;
public global::System.Boolean _performed;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target.ToResoniteReference(context));
members.Add("TargetParent", TargetParent.ToResoniteReference(context));
members.Add("_mode", _mode.ToResoniteLinkField());
members.Add("_preserveAssets", _preserveAssets.ToResoniteLinkField());
members.Add("_sendDestroyingEvents", _sendDestroyingEvents.ToResoniteLinkField());
members.Add("_savedObject", _savedObject.ToResoniteLinkField());
members.Add("_isComponent", _isComponent.ToResoniteLinkField());
members.Add("_referenceTable", _referenceTable.ToResoniteReference(context));
members.Add("_isSaving", _isSaving.ToResoniteLinkField());
members.Add("_description", _description.ToResoniteLinkField());
members.Add("_performed", _performed.ToResoniteLinkField());
}

}
}
