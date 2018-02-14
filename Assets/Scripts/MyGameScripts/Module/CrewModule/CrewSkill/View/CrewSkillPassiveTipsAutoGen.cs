﻿// ------------------------------------------------------------------------------
//  This code is generated by a tool
// ------------------------------------------------------------------------------

using UnityEngine;

public sealed partial class CrewSkillPassiveTips : BaseView
{
    public const string NAME ="CrewSkillPassiveTips";

    #region Element Bindings

    /// bind gameobject
    public Transform HaveLearned_Transform;
    public Transform NeedLearned_Transform;
    public UITexture itemIcon_UISprite;
    public UILabel lblGrade_UILabel;
    public UILabel lblType_UILabel;
    public UILabel lblName_UILabel;
    public UILabel lblEff_UILabel;
    public UILabel lblExp_UILabel;
    public UILabel lblProgress_UILabel;
    public UISlider Progress_UISlider;
    public UISlider TmpProgress_UISlider;
    public UIInput btnNum_UIInput;
    public UILabel Label_UILabel;
    public UIButton btnMinus_UIButton;
    public UIButton btnAdd_UIButton;
    public UIButton btnMax_UIButton;
    public UISprite consumIcon_UISprite;
    public UILabel lblNum_UILabel;
    public UIButton btnUp_UIButton;
    public UIButton btnUse_UIButton;
    public UIButton btnForget_UIButton;
    public UIGrid itemList_UIGrid;
    public UIGrid btnList_UIGrid;
    public UILabel lblTip_UILabel;
    public UIButton btnLearn_UIButton;
    public UILabel lblLearn_UILabel;
    public Transform ForgetWindow_Transform;
    public UIButton BlackBG_UIButton;
    public UILabel lblForgetName_UILabel;
    public UILabel lblForgetLevel_UILabel;
    public UIButton btnWindowForget_UIButton;
    public UIButton btnCancel_UIButton;
    public UILabel lblTipName_UILabel;
    public GameObject ScrollPanel;
    public Transform pool_Trans;

    protected override void InitElementBinding ()
    {
	    var root = this.gameObject;
        HaveLearned_Transform = root.FindTrans("HaveLearned");
        NeedLearned_Transform = root.FindTrans("NeedLearned");
        itemIcon_UISprite = root.FindScript<UITexture>("HaveLearned/item/itemIcon");
        lblGrade_UILabel = root.FindScript<UILabel>("HaveLearned/item/lblGrade");
        lblType_UILabel = root.FindScript<UILabel>("HaveLearned/lblType");
        lblName_UILabel = root.FindScript<UILabel>("HaveLearned/lblName");
        lblEff_UILabel = root.FindScript<UILabel>("HaveLearned/lblEff");
        lblExp_UILabel = root.FindScript<UILabel>("HaveLearned/Consum/exp/lblExp");
        lblProgress_UILabel = root.FindScript<UILabel>("HaveLearned/Consum/exp/lblProgress");
        Progress_UISlider = root.FindScript<UISlider>("HaveLearned/Consum/exp/Progress");
        TmpProgress_UISlider = root.FindScript<UISlider>("HaveLearned/Consum/exp/TmpProgress");
        btnNum_UIInput = root.FindScript<UIInput>("HaveLearned/Consum/Btn/btnNum");
        Label_UILabel = root.FindScript<UILabel>("HaveLearned/Consum/Btn/btnNum/Label");
        btnMinus_UIButton = root.FindScript<UIButton>("HaveLearned/Consum/Btn/btnMinus");
        btnAdd_UIButton = root.FindScript<UIButton>("HaveLearned/Consum/Btn/btnAdd");
        btnMax_UIButton = root.FindScript<UIButton>("HaveLearned/Consum/Btn/btnMax");
        consumIcon_UISprite = root.FindScript<UISprite>("HaveLearned/Consum/Item/consumIcon");
        lblNum_UILabel = root.FindScript<UILabel>("HaveLearned/Consum/Item/lblNum");
        btnUp_UIButton = root.FindScript<UIButton>("HaveLearned/btnUp");
        btnUse_UIButton = root.FindScript<UIButton>("HaveLearned/btnUse");
        btnForget_UIButton = root.FindScript<UIButton>("HaveLearned/btnForget");
        ScrollPanel = root.FindGameObject("NeedLearned/ScrollPanel");
        itemList_UIGrid = root.FindScript<UIGrid>("NeedLearned/ScrollPanel/itemList");
        btnList_UIGrid = root.FindScript<UIGrid>("NeedLearned/btnList");
        lblTip_UILabel = root.FindScript<UILabel>("NeedLearned/lblTip");
        btnLearn_UIButton = root.FindScript<UIButton>("NeedLearned/btnLearn");
        lblLearn_UILabel = root.FindScript<UILabel>("NeedLearned/lblLearn");
        ForgetWindow_Transform = root.FindTrans("ForgetWindow");
        BlackBG_UIButton = root.FindScript<UIButton>("ForgetWindow/BlackBG");
        lblForgetName_UILabel = root.FindScript<UILabel>("ForgetWindow/lblForgetName");
        lblForgetLevel_UILabel = root.FindScript<UILabel>("ForgetWindow/lblForgetLevel");
        btnWindowForget_UIButton = root.FindScript<UIButton>("ForgetWindow/btnWindowForget");
        btnCancel_UIButton = root.FindScript<UIButton>("ForgetWindow/btnCancel");
        lblTipName_UILabel = root.FindScript<UILabel>("NeedLearned/lblTipName");
        pool_Trans = root.FindTrans("NeedLearned/ScrollPanel/pool");
    }
    #endregion
}