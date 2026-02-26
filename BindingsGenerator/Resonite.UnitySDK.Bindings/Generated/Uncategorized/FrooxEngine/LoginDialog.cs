
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LoginDialog
// Generated on: čtvrtek 26. února 2026 10:04:47
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LoginDialog")]
public partial class LoginDialog : global::FrooxEngine.Component

{
    public global::System.Boolean RegisterOnly { get => RegisterOnly_Element.Data; set => RegisterOnly_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> RegisterOnly_Element = new();
public global::System.Boolean _interactionEnabled { get => _interactionEnabled_Element.Data; set => _interactionEnabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _interactionEnabled_Element = new();
public global::FrooxEngine.UIX.SlideSwapRegion _swapRegion { get => _swapRegion_Element.Data; set => _swapRegion_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.SlideSwapRegion>, global::FrooxEngine.UIX.SlideSwapRegion> _swapRegion_Element = new();
public global::FrooxEngine.UIX.TextField _username { get => _username_Element.Data; set => _username_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.TextField>, global::FrooxEngine.UIX.TextField> _username_Element = new();
public global::FrooxEngine.UIX.TextField _email { get => _email_Element.Data; set => _email_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.TextField>, global::FrooxEngine.UIX.TextField> _email_Element = new();
public global::FrooxEngine.UIX.TextField _emailRepeat { get => _emailRepeat_Element.Data; set => _emailRepeat_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.TextField>, global::FrooxEngine.UIX.TextField> _emailRepeat_Element = new();
public global::FrooxEngine.UIX.TextField _password { get => _password_Element.Data; set => _password_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.TextField>, global::FrooxEngine.UIX.TextField> _password_Element = new();
public global::FrooxEngine.UIX.TextField _passwordRepeat { get => _passwordRepeat_Element.Data; set => _passwordRepeat_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.TextField>, global::FrooxEngine.UIX.TextField> _passwordRepeat_Element = new();
public global::FrooxEngine.UIX.TextField _recoveryCode { get => _recoveryCode_Element.Data; set => _recoveryCode_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.TextField>, global::FrooxEngine.UIX.TextField> _recoveryCode_Element = new();
public global::FrooxEngine.IntTextEditorParser _birthMonth { get => _birthMonth_Element.Data; set => _birthMonth_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IntTextEditorParser>, global::FrooxEngine.IntTextEditorParser> _birthMonth_Element = new();
public global::FrooxEngine.IntTextEditorParser _birthDay { get => _birthDay_Element.Data; set => _birthDay_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IntTextEditorParser>, global::FrooxEngine.IntTextEditorParser> _birthDay_Element = new();
public global::FrooxEngine.IntTextEditorParser _birthYear { get => _birthYear_Element.Data; set => _birthYear_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IntTextEditorParser>, global::FrooxEngine.IntTextEditorParser> _birthYear_Element = new();
public global::FrooxEngine.UIX.Checkbox _rememberLogin { get => _rememberLogin_Element.Data; set => _rememberLogin_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Checkbox>, global::FrooxEngine.UIX.Checkbox> _rememberLogin_Element = new();
public global::FrooxEngine.UIX.Checkbox _resetUserId { get => _resetUserId_Element.Data; set => _resetUserId_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Checkbox>, global::FrooxEngine.UIX.Checkbox> _resetUserId_Element = new();
public global::FrooxEngine.UIX.Checkbox _policies { get => _policies_Element.Data; set => _policies_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Checkbox>, global::FrooxEngine.UIX.Checkbox> _policies_Element = new();
public global::FrooxEngine.UIX.Button _registerButton { get => _registerButton_Element.Data; set => _registerButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _registerButton_Element = new();
public global::System.String _loginEmail { get => _loginEmail_Element.Data; set => _loginEmail_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> _loginEmail_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("RegisterOnly", RegisterOnly_Element.Data.ToResoniteLinkField());
members.Add("_interactionEnabled", _interactionEnabled_Element.Data.ToResoniteLinkField());
members.Add("_swapRegion", _swapRegion_Element.Data.ToResoniteReference(context));
members.Add("_username", _username_Element.Data.ToResoniteReference(context));
members.Add("_email", _email_Element.Data.ToResoniteReference(context));
members.Add("_emailRepeat", _emailRepeat_Element.Data.ToResoniteReference(context));
members.Add("_password", _password_Element.Data.ToResoniteReference(context));
members.Add("_passwordRepeat", _passwordRepeat_Element.Data.ToResoniteReference(context));
members.Add("_recoveryCode", _recoveryCode_Element.Data.ToResoniteReference(context));
members.Add("_birthMonth", _birthMonth_Element.Data.ToResoniteReference(context));
members.Add("_birthDay", _birthDay_Element.Data.ToResoniteReference(context));
members.Add("_birthYear", _birthYear_Element.Data.ToResoniteReference(context));
members.Add("_rememberLogin", _rememberLogin_Element.Data.ToResoniteReference(context));
members.Add("_resetUserId", _resetUserId_Element.Data.ToResoniteReference(context));
members.Add("_policies", _policies_Element.Data.ToResoniteReference(context));
members.Add("_registerButton", _registerButton_Element.Data.ToResoniteReference(context));
members.Add("_loginEmail", _loginEmail_Element.Data.ToResoniteLinkField());
}

}
}
