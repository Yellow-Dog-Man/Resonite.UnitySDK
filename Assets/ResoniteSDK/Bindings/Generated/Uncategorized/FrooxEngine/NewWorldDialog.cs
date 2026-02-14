
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.NewWorldDialog
// Generated on: sobota 14. února 2026 8:58:46
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.NewWorldDialog")]
public partial class NewWorldDialog : global::FrooxEngine.Component

{
    public global::FrooxEngine.UIX.TextField _worldName;
public global::FrooxEngine.UIX.Checkbox _mobileFriendly;
public global::FrooxEngine.UIX.Checkbox _unsafeMode;
public global::FrooxEngine.UIX.Checkbox _autoPort;
public global::FrooxEngine.UIX.TextField _port;
public global::SkyFrost.Base.SessionAccessLevel _accessLevel;
public global::System.Int32 _presetIndex;
public global::System.Boolean _uiBuilt;
public System.Collections.Generic.List<global::FrooxEngine.UIX.ValueRadio<global::SkyFrost.Base.SessionAccessLevel>> _accessLevelRadios;
public global::System.Boolean _initialized;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_worldName", _worldName.ToResoniteReference(context));
members.Add("_mobileFriendly", _mobileFriendly.ToResoniteReference(context));
members.Add("_unsafeMode", _unsafeMode.ToResoniteReference(context));
members.Add("_autoPort", _autoPort.ToResoniteReference(context));
members.Add("_port", _port.ToResoniteReference(context));
members.Add("_accessLevel", _accessLevel.ToResoniteLinkField());
members.Add("_presetIndex", _presetIndex.ToResoniteLinkField());
members.Add("_uiBuilt", _uiBuilt.ToResoniteLinkField());
members.Add("_accessLevelRadios", new ResoniteLink.SyncList()
{
    Elements = _accessLevelRadios.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("_initialized", _initialized.ToResoniteLinkField());
}

}
}
