﻿//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
// </auto-generated>
//------------------------------------------------------------------------------
using Assets.Scripts.MyGameScripts.Module.RoleSkillModule.View;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Generates a safe wrapper for _ModuleName_View.
/// </summary>
public partial class RoleSkillPotentialView : BaseView
{
    public const string NAME ="RoleSkillPotentialView";

    #region Element Bindings

    /// bind gameobject
        public Transform SkillPotentialItem1_Transform;
    public Transform SkillPotentialItem2_Transform;
    public Transform SkillPotentialItem3_Transform;
    public Transform SkillPotentialItem4_Transform;
    public Transform SkillPotentialItem5_Transform;
    public Transform SkillPotentialItem6_Transform;
    public UILabel lblDesc_UILabel;
    public UILabel lblEffect_UILabel;
    public UILabel lblEffect2_UILabel;
    public UILabel lblCost_UILabel;
    public UILabel lblHave_UILabel;
    public UIButton btnUp_UIButton;
    public UIButton btnUp_10_UIButton;
    public List<RoleSkillPotentialItem> itemList;

    protected override void InitElementBinding ()
    {
	var root = this.gameObject;
                SkillPotentialItem1_Transform = root.FindTrans("leftContent/SkillPotentialItem1");
        SkillPotentialItem2_Transform = root.FindTrans("leftContent/SkillPotentialItem2");
        SkillPotentialItem3_Transform = root.FindTrans("leftContent/SkillPotentialItem3");
        SkillPotentialItem4_Transform = root.FindTrans("leftContent/SkillPotentialItem4");
        SkillPotentialItem5_Transform = root.FindTrans("leftContent/SkillPotentialItem5");
        SkillPotentialItem6_Transform = root.FindTrans("leftContent/SkillPotentialItem6");
        lblDesc_UILabel = root.FindScript<UILabel>("rightContent/lblDesc");
        lblEffect_UILabel = root.FindScript<UILabel>("rightContent/lblEffect");
        lblEffect2_UILabel = root.FindScript<UILabel>("rightContent/lblEffect2");
        lblCost_UILabel = root.FindScript<UILabel>("rightContent/lblCost");
        lblHave_UILabel = root.FindScript<UILabel>("rightContent/lblHave");
        btnUp_UIButton = root.FindScript<UIButton>("rightContent/btnUp");
        btnUp_10_UIButton = root.FindScript<UIButton>("rightContent/btnUp_10");

    }
    #endregion
}
