﻿//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine;
using System.Collections;

/// <summary>
/// Generates a safe wrapper for QRCodeScanView.
/// </summary>
public partial class QRCodeScanView : BaseView
{
	public UITexture ScanTexture_UITexture;
	public UILabel TipLabel_UILabel;
	public UIButton ReturnBtn_UIButton;
	public UIWidget ViewTexture_UIWidget;

	protected override void InitElementBinding ()
    {
        var root = this.gameObject.transform;
		ScanTexture_UITexture = root.Find("ScanTexture").GetComponent<UITexture>();
		TipLabel_UILabel = root.Find("Front/Sprite/TipLabel").GetComponent<UILabel>();
		ReturnBtn_UIButton = root.Find("Front/ReturnBtn").GetComponent<UIButton>();
		ViewTexture_UIWidget = root.Find("Front/ViewTexture").GetComponent<UIWidget>();
	}
}