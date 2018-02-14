﻿// ------------------------------------------------------------------------------
//  This code is generated by a tool
// ------------------------------------------------------------------------------

using UnityEngine;

public sealed class MainUIExpandContentView : BaseView
{
    public const string NAME ="MainUIExpandContentView";

    #region Element Bindings

    /// bind gameobject
    public GameObject ContentRoot;
    public UIButton TabBtn_Task_UIButton;
    public UISprite Arrow_UISprite;
    public UIButton cancelMatchBtn_UIButton;
    public UIButton joinOrLeaveBtn_UIButton;
    public UILabel callOrAwayBtnLbl_UILabel;
    public UIGrid operateBtnGrid_UIGrid;
    public UILabel joinOrLeaveBtnLbl_UILabel;
    public UIScrollView itemScrollView_UIScrollView;
    public UISprite itemOperateBtnBg_UISprite;
    public TweenAlpha TabContentRoot_TweenAlpha;
    public TweenPosition TabContentRoot_TweenPosition;
    public UIButton callOrAwayBtn_UIButton;
    public UIButton teamMsgBtn_UIButton;
    public UIButton TeamRequestBtn;
    public GameObject teamBtnGroup;
    public UILabel contentBgLbl_UILabel;
    public UISprite directSprite_UISprite;
    public UIButton TabBtn_Team_UIButton;
    public UITable MissionTable_UITable;
    public UIGrid TeamGrid_UIGrid;
    public UILabel MissonLb_UILabel;
    public GameObject MissonSelect;
    public GameObject TeamSelect;
    public UILabel TeamLb_UILabel;
    public UIPanel itemOperateGroup_UIPanel;


    protected override void InitElementBinding ()
    {
	    var root = this.gameObject;
        ContentRoot = root.FindGameObject("ContentRoot");
        TabBtn_Task_UIButton = root.FindScript<UIButton>("ContentRoot/TabButtonRoot/TabBtn_Task");
        Arrow_UISprite = root.FindScript<UISprite>("Button_ExpandPanel/teamMsgBtn/Arrow");
        cancelMatchBtn_UIButton = root.FindScript<UIButton>("ContentRoot/TabContentRoot/teamBtnGroup/cancelMatchBtn");
        joinOrLeaveBtn_UIButton = root.FindScript<UIButton>("ContentRoot/TabContentRoot/teamBtnGroup/joinOrLeaveBtn");
        callOrAwayBtnLbl_UILabel = root.FindScript<UILabel>("ContentRoot/TabContentRoot/teamBtnGroup/callOrAwayBtn/callOrAwayBtnLbl");
        operateBtnGrid_UIGrid = root.FindScript<UIGrid>("ContentRoot/TabContentRoot/teamBtnGroup/itemOperateGroup/directSprite/itemOperateBtnBg/operateBtnGrid");
        joinOrLeaveBtnLbl_UILabel = root.FindScript<UILabel>("ContentRoot/TabContentRoot/teamBtnGroup/joinOrLeaveBtn/joinOrLeaveBtnLbl");
        itemScrollView_UIScrollView = root.FindScript<UIScrollView>("ContentRoot/TabContentRoot/itemScrollView");
        itemOperateBtnBg_UISprite = root.FindScript<UISprite>("ContentRoot/TabContentRoot/teamBtnGroup/itemOperateGroup/directSprite/itemOperateBtnBg");
        TabContentRoot_TweenAlpha = root.FindScript<TweenAlpha>("ContentRoot/TabContentRoot");
        TabContentRoot_TweenPosition = root.FindScript<TweenPosition>("ContentRoot/TabContentRoot");
        callOrAwayBtn_UIButton = root.FindScript<UIButton>("ContentRoot/TabContentRoot/teamBtnGroup/callOrAwayBtn");
        teamMsgBtn_UIButton = root.FindScript<UIButton>("Button_ExpandPanel/teamMsgBtn");
        TeamRequestBtn = root.FindScript<UIButton>("Button_ExpandPanel/TeamRequestBtn");
        teamBtnGroup = root.FindGameObject("ContentRoot/TabContentRoot/teamBtnGroup");
        contentBgLbl_UILabel = root.FindScript<UILabel>("ContentRoot/TabContentRoot/teamBtnGroup/contentBgLbl");
        directSprite_UISprite = root.FindScript<UISprite>("ContentRoot/TabContentRoot/teamBtnGroup/itemOperateGroup/directSprite");
        TabBtn_Team_UIButton = root.FindScript<UIButton>("ContentRoot/TabButtonRoot/TabBtn_Team");
        MissionTable_UITable = root.FindScript<UITable>("ContentRoot/TabContentRoot/itemScrollView/MissionTable");
        TeamGrid_UIGrid = root.FindScript<UIGrid>("ContentRoot/TabContentRoot/itemScrollView/TeamGrid");
        MissonLb_UILabel = root.FindScript<UILabel>("ContentRoot/TabButtonRoot/TabBtn_Task/MissonLb");
        MissonSelect = root.FindGameObject("ContentRoot/TabButtonRoot/TabBtn_Task/MissonSelect");
        TeamSelect = root.FindGameObject("ContentRoot/TabButtonRoot/TabBtn_Team/TeamSelect");
        TeamLb_UILabel = root.FindScript<UILabel>("ContentRoot/TabButtonRoot/TabBtn_Team/TeamLb");
        itemOperateGroup_UIPanel = root.FindScript<UIPanel>("ContentRoot/TabContentRoot/teamBtnGroup/itemOperateGroup");

    }
    #endregion
}