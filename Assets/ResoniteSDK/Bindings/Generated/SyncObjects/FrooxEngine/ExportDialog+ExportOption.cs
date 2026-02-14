
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ExportDialog+ExportOption
// Generated on: sobota 14. února 2026 8:58:43
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
