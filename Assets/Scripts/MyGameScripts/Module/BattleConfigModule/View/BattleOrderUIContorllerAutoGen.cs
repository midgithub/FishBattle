﻿// ------------------------------------------------------------------------------
//  This code is generated by a tool
// ------------------------------------------------------------------------------

using UnityEngine;

public sealed partial class BattleOrderUIContorller : BaseView
{
    public const string NAME ="BattleOrderUIContorller";

    #region Element Bindings

    /// bind gameobject
    public Transform ContorllerBG_Transform;
    public Transform MoveButton_Transform;
    public UIButton MoveButton_UIButton;
    public Transform MagicButton_Transform;
    public UIButton MagicButton_UIButton;
    public Transform EscapeButton_Transform;
    public UIButton EscapeButton_UIButton;
    public Transform AttackButton_Transform;
    public UIButton AttackButton_UIButton;
    public Transform UserItemButton_Transform;
    public UIButton UserItemButton_UIButton;
    public Transform SkillButton_Transform;
    public UIButton SkillButton_UIButton;
    public TweenScale BodyTween_TweenScale;
    public UIButton CallButton_UIButton;
    public UITexture QuickIcon_UITexture;

    protected override void InitElementBinding ()
    {
	    var root = this.gameObject;
        ContorllerBG_Transform = root.FindTrans("ContorllerBG");
        MoveButton_Transform = root.FindTrans("InstructionsButtonArr/MoveButton");
        MoveButton_UIButton = root.FindScript<UIButton>("InstructionsButtonArr/MoveButton");
        MagicButton_Transform = root.FindTrans("InstructionsButtonArr/MagicButton");
        MagicButton_UIButton = root.FindScript<UIButton>("InstructionsButtonArr/MagicButton");
        EscapeButton_Transform = root.FindTrans("InstructionsButtonArr/EscapeButton");
        EscapeButton_UIButton = root.FindScript<UIButton>("InstructionsButtonArr/EscapeButton");
        AttackButton_Transform = root.FindTrans("InstructionsButtonArr/AttackButton");
        AttackButton_UIButton = root.FindScript<UIButton>("InstructionsButtonArr/AttackButton");
        UserItemButton_Transform = root.FindTrans("InstructionsButtonArr/UserItemButton");
        UserItemButton_UIButton = root.FindScript<UIButton>("InstructionsButtonArr/UserItemButton");
        SkillButton_Transform = root.FindTrans("InstructionsButtonArr/SkillButton");
        SkillButton_UIButton = root.FindScript<UIButton>("InstructionsButtonArr/SkillButton");
        BodyTween_TweenScale = root.GetComponent<TweenScale>();
        CallButton_UIButton = root.FindScript<UIButton>("ContorllerBG/CallButton");
        QuickIcon_UITexture = root.FindScript<UITexture>("InstructionsButtonArr/MoveButton/QuickIcon");
    }
    #endregion
}