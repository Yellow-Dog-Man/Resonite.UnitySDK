
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.NewWorldDialog
// Generated on: čtvrtek 26. února 2026 15:09:13
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.NewWorldDialog")]
public partial class NewWorldDialog : global::FrooxEngine.Component

{
    public global::FrooxEngine.UIX.TextField _worldName { get => _worldName_Element.Data; set => _worldName_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.TextField>, global::FrooxEngine.UIX.TextField> _worldName_Element = new();
public global::FrooxEngine.UIX.Checkbox _mobileFriendly { get => _mobileFriendly_Element.Data; set => _mobileFriendly_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Checkbox>, global::FrooxEngine.UIX.Checkbox> _mobileFriendly_Element = new();
public global::FrooxEngine.UIX.Checkbox _unsafeMode { get => _unsafeMode_Element.Data; set => _unsafeMode_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Checkbox>, global::FrooxEngine.UIX.Checkbox> _unsafeMode_Element = new();
public global::FrooxEngine.UIX.Checkbox _autoPort { get => _autoPort_Element.Data; set => _autoPort_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Checkbox>, global::FrooxEngine.UIX.Checkbox> _autoPort_Element = new();
public global::FrooxEngine.UIX.TextField _port { get => _port_Element.Data; set => _port_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.TextField>, global::FrooxEngine.UIX.TextField> _port_Element = new();
public global::SkyFrost.Base.SessionAccessLevel _accessLevel { get => _accessLevel_Element.Data; set => _accessLevel_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::SkyFrost.Base.SessionAccessLevel>, global::SkyFrost.Base.SessionAccessLevel> _accessLevel_Element = new();
public global::System.Int32 _presetIndex { get => _presetIndex_Element.Data; set => _presetIndex_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> _presetIndex_Element = new();
public global::System.Boolean _uiBuilt { get => _uiBuilt_Element.Data; set => _uiBuilt_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _uiBuilt_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.UIX.ValueRadio<global::SkyFrost.Base.SessionAccessLevel>>, global::FrooxEngine.UIX.ValueRadio<global::SkyFrost.Base.SessionAccessLevel>, Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.ValueRadio<global::SkyFrost.Base.SessionAccessLevel>>, global::FrooxEngine.UIX.ValueRadio<global::SkyFrost.Base.SessionAccessLevel>>> _accessLevelRadios = new();
public global::System.Boolean _initialized { get => _initialized_Element.Data; set => _initialized_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _initialized_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_worldName", _worldName_Element.ToLinkReference(context));
members.Add("_mobileFriendly", _mobileFriendly_Element.ToLinkReference(context));
members.Add("_unsafeMode", _unsafeMode_Element.ToLinkReference(context));
members.Add("_autoPort", _autoPort_Element.ToLinkReference(context));
members.Add("_port", _port_Element.ToLinkReference(context));
members.Add("_accessLevel", _accessLevel_Element.ToLinkField(context));
members.Add("_presetIndex", _presetIndex_Element.ToLinkField(context));
members.Add("_uiBuilt", _uiBuilt_Element.ToLinkField(context));
members.Add("_accessLevelRadios", _accessLevelRadios.ToLinkList(context, m => m.ToLinkReference(context)));
members.Add("_initialized", _initialized_Element.ToLinkField(context));
}

}
}
