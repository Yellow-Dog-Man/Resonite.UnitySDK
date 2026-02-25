
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ExportDialog+ExportOption
// Generated on: středa 25. února 2026 16:14:37
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    public partial class ExportDialog
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ExportDialog+ExportOption")]
public partial class ExportOption : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.IExportable Exportable;
public global::System.Int32 ExportType;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Exportable", Exportable.ToResoniteReference(context));
members.Add("ExportType", ExportType.ToResoniteLinkField());
}

}
            }
}
