﻿// ------------------------------------------------------------------------------
//  This code is generated by a tool
// ------------------------------------------------------------------------------

using UnityEngine;

public sealed class DelegateMissionEffectPanel : BaseView
{
    public const string NAME ="DelegateMissionEffectPanel";

    #region Element Bindings

    /// bind gameobject
    public UISprite Mask_UISprite;
    public UISprite NoticeSprite_UISprite;
    public TweenAlpha  Notice_TweenAlpha;


    protected override void InitElementBinding ()
    {
	    var root = this.gameObject;
        Mask_UISprite = root.FindScript<UISprite>("Mask");
        NoticeSprite_UISprite = root.FindScript<UISprite>("NoticeSprite");
        Notice_TweenAlpha = root.FindScript<TweenAlpha>("Mask");
    }
    #endregion
}