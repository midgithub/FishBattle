﻿// ------------------------------------------------------------------------------
//  This code is generated by a tool
// ------------------------------------------------------------------------------

using UnityEngine;

public sealed partial class PreviewTipsMainView : BaseView
{
    public const string NAME ="PreviewTipsMainView";

    #region Element Bindings

    /// bind gameobject
    public GameObject Content;
    public UITable Content_UITable;


    protected override void InitElementBinding ()
    {
	    var root = this.gameObject;
        Content = root.FindGameObject("Content");
        Content_UITable = root.FindScript<UITable>("Content");

    }
    #endregion
}