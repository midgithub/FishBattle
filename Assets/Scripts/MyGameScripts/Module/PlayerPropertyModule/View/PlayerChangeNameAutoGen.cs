﻿// ------------------------------------------------------------------------------
//  This code is generated by a tool
// ------------------------------------------------------------------------------

using UnityEngine;

public sealed class PlayerChangeName : BaseView
{
    public const string NAME ="PlayerChangeName";

    #region Element Bindings

    /// bind gameobject
    public UIButton LeftBtn_UIButton;
    public UIButton RightBtn_UIButton;
    public UIInput Input_UIInput;
    public Transform PetTransform_Transform;


    protected override void InitElementBinding ()
    {
	    var root = this.gameObject;
        LeftBtn_UIButton = root.FindScript<UIButton>("LeftBtn");
        RightBtn_UIButton = root.FindScript<UIButton>("RightBtn");
        Input_UIInput = root.FindScript<UIInput>("Input");
        PetTransform_Transform = root.FindTrans("PetTransform");

    }
    #endregion
}