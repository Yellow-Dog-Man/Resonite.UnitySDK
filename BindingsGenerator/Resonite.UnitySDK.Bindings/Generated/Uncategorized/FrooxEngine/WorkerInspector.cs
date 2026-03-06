
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WorkerInspector
// Generated on: pátek 6. března 2026 14:19:11
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.WorkerInspector")]
public partial class WorkerInspector : global::FrooxEngine.Component, global::FrooxEngine.IDeveloperInterface

{
    public global::FrooxEngine.Worker _targetContainer { get => _targetContainer_Element.Data; set => _targetContainer_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Worker>, global::FrooxEngine.Worker> _targetContainer_Element = new();
public global::FrooxEngine.Worker _targetWorker { get => _targetWorker_Element.Data; set => _targetWorker_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Worker>, global::FrooxEngine.Worker> _targetWorker_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_targetContainer", _targetContainer_Element.ToLinkReference(context));
members.Add("_targetWorker", _targetWorker_Element.ToLinkReference(context));
}

}
}
