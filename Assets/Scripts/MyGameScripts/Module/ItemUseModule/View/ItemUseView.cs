﻿//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine;
using System.Collections;

/// <summary>
/// Generates a safe wrapper for ItemUseView.
/// </summary>
public partial class ItemUseView : BaseView
{
	public const string NAME ="ItemUseView";
	public UIButton CloseBtn;
	public UIButton OptBtn;
	public UILabel OptlblLabel;
	public UIPageGrid itemGrid;
	public GameObject LGroup;
	public UILabel TitleLabel_UILabel;

	protected override void InitElementBinding ()
    {
        var root = this.gameObject.transform;
		CloseBtn = root.Find("RGroup/CloseBtn").GetComponent<UIButton>();
		OptBtn = root.Find("RGroup/OptBtn").GetComponent<UIButton>();
		OptlblLabel = root.Find("RGroup/OptBtn/OptlblLabel").GetComponent<UILabel>();
		itemGrid = root.Find("RGroup/ItemPanel/itemGrid").GetComponent<UIPageGrid>();
		LGroup = root.Find("LGroup").gameObject;
		TitleLabel_UILabel = root.Find("RGroup/TitleGroup/TitleLabel").GetComponent<UILabel>();
	}
}