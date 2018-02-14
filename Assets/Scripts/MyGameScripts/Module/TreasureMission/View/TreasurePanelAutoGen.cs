﻿// ------------------------------------------------------------------------------
//  This code is generated by a tool
// ------------------------------------------------------------------------------

using UnityEngine;

public sealed class TreasurePanel : BaseView
{
    public const string NAME ="TreasurePanel";

    #region Element Bindings

    /// bind gameobject
    public Transform RewardArr_Transform;
    public Transform Select_Transform;
    public UIButton TreasureBtn_UIButton;
    public UIButton OnClose_UIButton;
    public UILabel Label_UILabel;
    public UILabel DiamondsNumber_UILabel;
    public UILabel RewardNameLabel1_UILabel;
    public UILabel RewardNameLabel2_UILabel;
    public UILabel RewardNameLabel3_UILabel;
    public UISprite RewardIconl_UISprite;
    public UISprite RewardIcon2_UISprite;
    public UISprite RewardIcon3_UISprite;
    public GameObject FinalRewardPanel_GameObject;
    public Transform TurntableSlect_Transorm;
    public Transform Reward1_Transform;
    public Transform Reward2_Transform;
    public Transform Reward3_Transform;
    public Transform TurntableIcon_Transform;      //指针图标
    public Transform TurntableMask_Transform;       //转盘高亮背景
    public GameObject TurntablePanel_GameObject;
    public GameObject NormalLayer_GameObject;
    public UILabel TipPanel_UILabel;          //道具Tip
    public UIButton ReturnBtn_Button;
    public UIButton BGCollider_UIButton;
    public UIButton InfoTipsButton_UIButton;        //问号Tip
    public UILabel TreasureLabel_UILabel;

    protected override void InitElementBinding ()
    {
	    var root = this.gameObject;
        RewardArr_Transform = root.FindTrans("NormalLayer/RewardArr");
        Select_Transform = root.FindTrans("NormalLayer/RewardArr/Select");
        TreasureBtn_UIButton = root.FindScript<UIButton>("NormalLayer/TreasureBtn");
        OnClose_UIButton = root.FindScript<UIButton>("OnClose");
        Label_UILabel = root.FindScript<UILabel>("NormalLayer/Cost/Label");
        DiamondsNumber_UILabel = root.FindScript<UILabel>("NormalLayer/DiamondsNumber/Label");
        FinalRewardPanel_GameObject = root.FindGameObject("FinalRewardPanel");
        TurntableSlect_Transorm = root.FindScript<Transform>("FinalRewardPanel/FinalReward/ForeGreound/Prize/Select");
        Reward1_Transform = root.FindScript<Transform>("FinalRewardPanel/FinalReward/ForeGreound/Prize/Reward_1");
        Reward2_Transform = root.FindScript<Transform>("FinalRewardPanel/FinalReward/ForeGreound/Prize/Reward_2");
        Reward3_Transform = root.FindScript<Transform>("FinalRewardPanel/FinalReward/ForeGreound/Prize/Reward_3");
        ReturnBtn_Button = root.FindScript<UIButton>("FinalRewardPanel/FinalReward/ForeGreound/RetunBtn");
        RewardNameLabel1_UILabel = root.FindScript<UILabel>("FinalRewardPanel/FinalReward/ForeGreound/Prize/Reward_1/RewardLabel");
        RewardNameLabel2_UILabel = root.FindScript<UILabel>("FinalRewardPanel/FinalReward/ForeGreound/Prize/Reward_2/RewardLabel");
        RewardNameLabel3_UILabel = root.FindScript<UILabel>("FinalRewardPanel/FinalReward/ForeGreound/Prize/Reward_3/RewardLabel");
        RewardIconl_UISprite = root.FindScript<UISprite>("FinalRewardPanel/FinalReward/ForeGreound/Prize/Reward_1/BG");
        RewardIcon2_UISprite = root.FindScript<UISprite>("FinalRewardPanel/FinalReward/ForeGreound/Prize/Reward_2/BG");
        RewardIcon3_UISprite = root.FindScript<UISprite>("FinalRewardPanel/FinalReward/ForeGreound/Prize/Reward_3/BG");
        TurntableIcon_Transform = root.FindScript<Transform>("TurntablePanel/Turntable/ForeGreound/PointerGameObject");
        TurntableMask_Transform = root.FindScript<Transform>("TurntablePanel/Turntable/ForeGreound/Mask");
        TurntablePanel_GameObject = root.FindGameObject("TurntablePanel");
        BGCollider_UIButton = root.FindScript<UIButton>("NormalLayer/RewardArr");
        TipPanel_UILabel = root.FindScript<UILabel>("TipTrans/TipLabel");
        NormalLayer_GameObject = root.FindGameObject("NormalLayer");
        InfoTipsButton_UIButton = root.FindScript<UIButton>("NormalLayer/InfoTipsButton");
        TreasureLabel_UILabel = root.FindScript<UILabel>("TreasureLabel");
    }
    #endregion
}