﻿// ------------------------------------------------------------------------------
//  This code is generated by a tool
// ------------------------------------------------------------------------------

using UnityEngine;

public sealed class SkillEditorMainView : BaseView
{
    public const string NAME ="SkillEditorMainView";

    #region Element Bindings

    /// bind gameobject
    public UISprite LeftBack_UISprite;
    public UISprite TopBack_UISprite;
    public UIButton DelBtn_UIButton;
    public UIButton SaveAsBtn_UIButton;
    public UIButton SelectBtn_UIButton;
    public UIButton SaveBtn_UIButton;
    public UILabel SkillName_UILabel;
    public UIButton CharBtn_UIButton;
    public UILabel CharName_UILabel;
    public UIInput TeamAInput_UIInput;
    public UIInput TeamBInput_UIInput;
    public UIButton PlayBtn_UIButton;
    public UIInput TargetNumInput_UIInput;
    public UIToggle AtOnceToggle_UIToggle;
    public UIInput MultiPartInput_UIInput;
    public UIInput AttackInput_UIInput;
    public UIInput DefendInput_UIInput;
    public UIButton RandomBtn_UIButton;
    public UIButton InsertInfoBtn_UIButton;
    public UIButton DelInfoBtn_UIButton;
    public UIButton LineBtn_UIButton;
    public UIScrollView InfoScrollView_UIScrollView;
    public UIGrid InfoGrid_UIGrid;
    public UIButton UpInfoBtn_UIButton;
    public UIButton DownInfoBtn_UIButton;


    protected override void InitElementBinding ()
    {
	    var root = this.gameObject;
        LeftBack_UISprite = root.FindScript<UISprite>("Left/Back");
        TopBack_UISprite = root.FindScript<UISprite>("Top/Back");
        DelBtn_UIButton = root.FindScript<UIButton>("Top/Back/SkillInfo/Btns/DelBtn");
        SaveAsBtn_UIButton = root.FindScript<UIButton>("Top/Back/SkillInfo/Btns/SaveAsBtn");
        SelectBtn_UIButton = root.FindScript<UIButton>("Top/Back/SkillInfo/Btns/SelectBtn");
        SaveBtn_UIButton = root.FindScript<UIButton>("Top/Back/SkillInfo/Btns/SaveBtn");
        SkillName_UILabel = root.FindScript<UILabel>("Top/Back/SkillInfo/SkillName");
        CharBtn_UIButton = root.FindScript<UIButton>("Top/Back/SceneInfo/Btns/CharBtn");
        CharName_UILabel = root.FindScript<UILabel>("Top/Back/SceneInfo/Btns/CharBtn/CharName");
        TeamAInput_UIInput = root.FindScript<UIInput>("Top/Back/SceneInfo/Btns/TeamAInput");
        TeamBInput_UIInput = root.FindScript<UIInput>("Top/Back/SceneInfo/Btns/TeamBInput");
        PlayBtn_UIButton = root.FindScript<UIButton>("Top/Back/PlayBtn");
        TargetNumInput_UIInput = root.FindScript<UIInput>("Top/Back/BattleInfo/Btns/TargetNumInput");
        AtOnceToggle_UIToggle = root.FindScript<UIToggle>("Top/Back/BattleInfo/Btns/AtOnceToggle");
        MultiPartInput_UIInput = root.FindScript<UIInput>("Top/Back/BattleInfo/Btns/MultiPartInput");
        AttackInput_UIInput = root.FindScript<UIInput>("Top/Back/AttackInfo/Btns/AttackInput");
        DefendInput_UIInput = root.FindScript<UIInput>("Top/Back/AttackInfo/Btns/DefendInput");
        RandomBtn_UIButton = root.FindScript<UIButton>("Top/Back/AttackInfo/Btns/RandomBtn");
        InsertInfoBtn_UIButton = root.FindScript<UIButton>("Left/Back/Btns/InsertInfoBtn");
        DelInfoBtn_UIButton = root.FindScript<UIButton>("Left/Back/Btns/DelInfoBtn");
        LineBtn_UIButton = root.FindScript<UIButton>("Left/Back/Btns/LineBtn");
        InfoScrollView_UIScrollView = root.FindScript<UIScrollView>("Left/InfoScrollView");
        InfoGrid_UIGrid = root.FindScript<UIGrid>("Left/InfoScrollView/InfoGrid");
        UpInfoBtn_UIButton = root.FindScript<UIButton>("Left/Back/Btns/UpInfoBtn");
        DownInfoBtn_UIButton = root.FindScript<UIButton>("Left/Back/Btns/DownInfoBtn");

    }
    #endregion
}