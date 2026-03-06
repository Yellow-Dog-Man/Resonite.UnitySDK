
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FileBrowser
// Generated on: pátek 6. března 2026 14:19:08
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FileBrowser")]
public partial class FileBrowser : global::FrooxEngine.BrowserDialog

{
    public global::System.String CurrentPath { get => CurrentPath_Element.Data; set => CurrentPath_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> CurrentPath_Element = new();
public global::System.String _lastPath { get => _lastPath_Element.Data; set => _lastPath_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> _lastPath_Element = new();
public global::FrooxEngine.MachineUserRef _user = new();
public global::FrooxEngine.UIX.Button _importButton { get => _importButton_Element.Data; set => _importButton_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _importButton_Element = new();
public global::FrooxEngine.UIX.Button _rawImportButton { get => _rawImportButton_Element.Data; set => _rawImportButton_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _rawImportButton_Element = new();
public global::FrooxEngine.UIX.Button _createNewButton { get => _createNewButton_Element.Data; set => _createNewButton_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _createNewButton_Element = new();
public global::FrooxEngine.UIX.Button _reloadButton { get => _reloadButton_Element.Data; set => _reloadButton_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _reloadButton_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("CurrentPath", CurrentPath_Element.ToLinkField(context));
members.Add("_lastPath", _lastPath_Element.ToLinkField(context));
members.Add("_user", _user.ToLinkSyncObject(context));
members.Add("_importButton", _importButton_Element.ToLinkReference(context));
members.Add("_rawImportButton", _rawImportButton_Element.ToLinkReference(context));
members.Add("_createNewButton", _createNewButton_Element.ToLinkReference(context));
members.Add("_reloadButton", _reloadButton_Element.ToLinkReference(context));
}

}
}
