﻿//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine;
using System.Collections;

/// <summary>
/// Generates a safe wrapper for _ModuleName_View.
/// </summary>
public partial class ExpressionBtn : BaseView
{
    public const string NAME ="ExpressionBtn";

    #region Element Bindings

    /// bind gameobject
        public UILabel btnLbl_UILabel;
    public UISprite SelectEff_UISprite;
    public BoxCollider ExpressionBtn_BoxCollider;
    public UISprite face_UISprite;
    public UISprite Expression_UISprite;

    protected override void InitElementBinding ()
    {
	var root = this.gameObject;
                btnLbl_UILabel = root.FindScript<UILabel>("btnLbl");
        SelectEff_UISprite = root.FindScript<UISprite>("SelectEff");
        ExpressionBtn_BoxCollider = root.FindScript<BoxCollider>("");
        face_UISprite = root.FindScript<UISprite>("face");
        Expression_UISprite = root.FindScript<UISprite>("");

    }
    #endregion
}
