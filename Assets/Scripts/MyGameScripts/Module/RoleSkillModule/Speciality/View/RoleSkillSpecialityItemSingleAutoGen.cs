﻿//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine;


/// <summary>
/// Generates a safe wrapper for _ModuleName_View.
/// </summary>
public partial class RoleSkillSpecialityItemSingle : BaseView
{
    public const string NAME ="RoleSkillSpecialityItemSingle";

    #region Element Bindings

    /// bind gameobject
        public UILabel lblName_UILabel;
    public UILabel lblEff_UILabel;
    public Transform goEdit_Transform;
    public Transform goNormal_Transform;
    public UIButton btnAdd_UIButton;
    public UIButton btnSub_UIButton;
    public UILabel lblEditNum_UILabel;
    public UILabel lblNormalNum_UILabel;
    public UIWidget RoleSkillSpecialityItemSingle_UIWidget;
    public UIButton btnInput_UIButton;
    public Transform KeyTrans;


    protected override void InitElementBinding ()
    {
	var root = this.gameObject;
                lblName_UILabel = root.FindScript<UILabel>("lblName");
        lblEff_UILabel = root.FindScript<UILabel>("lblEff");
        goEdit_Transform = root.FindTrans("Content/goEdit");
        goNormal_Transform = root.FindTrans("Content/goNormal");
        btnAdd_UIButton = root.FindScript<UIButton>("Content/goEdit/btnAdd");
        btnSub_UIButton = root.FindScript<UIButton>("Content/goEdit/btnSub");
        lblEditNum_UILabel = root.FindScript<UILabel>("Content/goEdit/lblEditNum");
        lblNormalNum_UILabel = root.FindScript<UILabel>("Content/goNormal/lblNormalNum");
        RoleSkillSpecialityItemSingle_UIWidget = root.FindScript<UIWidget>("");
        btnInput_UIButton = root.FindScript<UIButton>("Content/goEdit/spBg");
        KeyTrans = root.FindTrans("KeyTrans");

    }
    #endregion
}
