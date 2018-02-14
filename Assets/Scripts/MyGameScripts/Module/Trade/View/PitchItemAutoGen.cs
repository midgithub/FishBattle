﻿// ------------------------------------------------------------------------------
//  This code is generated by a tool
// ------------------------------------------------------------------------------

using UnityEngine;

public sealed class PitchItem : BaseView
{
    public const string NAME ="PitchItem";

    #region Element Bindings

    /// bind gameobject
    public UIButton PitchItem_UIButton;
    public UISprite Background_UISprite;
    public UILabel CountLb_UILabel;
    public UILabel NameLb_UILabel;
    public UISprite CashIcon_UISprite;
    public UILabel CashLb_UILabel;
    public UISprite State_UISprite;
    public BoxCollider LockBtn_BoxCollider;
    public UISprite IconSpr_UISprite;
    public UIButton AddBtn_UIButton;
    public UISprite LittleIcon_UISprite;
    public UISprite Arrow_UISprite;
    public UILabel DescLb_UILabel;
    public UILabel PriceLb_UILabel;
    public UISprite SelectSpr_UISprite;
    public UIWidget UIWidget;
    public BoxCollider BoxCollider;
    public UISprite Icon_UISprite;
    public UIButton LockBtn_UIButton;
    public UILabel LockLb_UILabel;
    public UIDragScrollView PitchItem_UIDragScrollView;


    protected override void InitElementBinding ()
    {
	    var root = this.gameObject;
        PitchItem_UIButton = root.FindScript<UIButton>("");
        Background_UISprite = root.FindScript<UISprite>("Background");
        CountLb_UILabel = root.FindScript<UILabel>("IconGroup/CountLb");
        NameLb_UILabel = root.FindScript<UILabel>("NameLb");
        CashIcon_UISprite = root.FindScript<UISprite>("CashIcon");
        CashLb_UILabel = root.FindScript<UILabel>("CashLb");
        State_UISprite = root.FindScript<UISprite>("IconGroup/State");
        LockBtn_BoxCollider = root.FindScript<BoxCollider>("IconGroup/LockBtn");
        IconSpr_UISprite = root.FindScript<UISprite>("IconGroup/IconSpr");
        AddBtn_UIButton = root.FindScript<UIButton>("IconGroup/AddBtn");
        LittleIcon_UISprite = root.FindScript<UISprite>("IconGroup/LittleIcon");
        Arrow_UISprite = root.FindScript<UISprite>("Arrow");
        DescLb_UILabel = root.FindScript<UILabel>("DescLb");
        PriceLb_UILabel = root.FindScript<UILabel>("PriceLb");
        SelectSpr_UISprite = root.FindScript<UISprite>("SelectSpr");
        UIWidget = root.FindScript<UIWidget>("");
        BoxCollider = root.FindScript<BoxCollider>("");
        Icon_UISprite = root.FindScript<UISprite>("IconGroup/Icon");
        LockBtn_UIButton = root.FindScript<UIButton>("IconGroup/LockBtn");
        LockLb_UILabel = root.FindScript<UILabel>("LockLb");
        PitchItem_UIDragScrollView = root.FindScript<UIDragScrollView>("");

    }
    #endregion
}