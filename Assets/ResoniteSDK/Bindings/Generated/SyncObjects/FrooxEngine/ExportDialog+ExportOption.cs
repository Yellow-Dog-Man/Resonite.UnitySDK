
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ExportDialog+ExportOption
// Generated on: úterý 24. února 2026 18:20:20
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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
