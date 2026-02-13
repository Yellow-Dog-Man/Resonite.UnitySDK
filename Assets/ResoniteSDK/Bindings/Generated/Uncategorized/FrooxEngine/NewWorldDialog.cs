
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.NewWorldDialog
// Generated on: pátek 13. února 2026 23:23:16
// Resonite version: 2026.2.12.359
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("_worldName", new ResoniteLink.Reference() { });
members.Add("_mobileFriendly", new ResoniteLink.Reference() { });
members.Add("_unsafeMode", new ResoniteLink.Reference() { });
members.Add("_autoPort", new ResoniteLink.Reference() { });
members.Add("_port", new ResoniteLink.Reference() { });
members.Add("_accessLevel", _accessLevel.ToResoniteLinkField());
members.Add("_presetIndex", _presetIndex.ToResoniteLinkField());
members.Add("_uiBuilt", _uiBuilt.ToResoniteLinkField());
members.Add("_accessLevelRadios", new ResoniteLink.SyncList()
{
    Elements = _accessLevelRadios.ConvertList(m => new ResoniteLink.Reference() { })
});
members.Add("_initialized", _initialized.ToResoniteLinkField());
}

}
}
