﻿// **********************************************************************
// Copyright (c) 2016 Baoyugame. All rights reserved.
// Author : Xianjian
// Created : 9/29/2016 10:20:20 AM
// Desc	: Auto generated by MarsZ. update this if need.
// **********************************************************************

using UnityEngine;
using SdkAccountDto;

 /// <summary>
 /// This is the controller class for module AccountSDKBase, use this to control the ui or view , such as it's init , update or dispose.
 /// @Xianjian in 9/29/2016 10:20:20 AM
 /// </summary>
public class SdkBaseController : MonoViewController<SdkBaseView>
{
    public static SdkBaseController Instance;
    public static void Setup(GameObject module)
    {
        Instance = module.GetMissingComponent<SdkBaseController>();
        Instance.Open();
    }

    public static GameObject PreLoginObject { get { return Instance._view.PreLogin.gameObject; } }
    public static GameObject GameCenterObject { get { return Instance._view.GameCenter.gameObject; } }
    public static GameObject GameCenterBarObject { get { return Instance._view.GameCenterBarTrans.gameObject; } }
    public static Vector3 PreLoginPos { get { return Instance._view.PreLogin.position; } }
    public static Vector3 PreLoginHidePos { get { return Instance._view.HidePos.position; } }
    //用户中心主界面pos
    public static Vector3 GameCenterPos { get { return Instance._view.GameCenter.position; } }
    //用户中心主界面隐藏pos
    public static Vector3 GameCenterHidePos { get { return Instance._view.GameCenterHidePosTrans.position; } }

    private bool _isExpand=true;
    public SdkModuleMgr.ModuleType PreModuleType = SdkModuleMgr.ModuleType.preLogin;

    public void Open()
	{
	}

    public static void SetModuleType(SdkModuleMgr.ModuleType type)
    {
        if (Instance.PreModuleType == type) return;

        //清楚之前的显示
        SdkProxyModule.ClearModule();

        Instance.PreModuleType = type;

        if(type == SdkModuleMgr.ModuleType.preLogin)
        {
            if (SdkAccountModel.Instance.IsLogin())
            {
                Instance.SetExpand(false);
            }
            else
            {
                GameCenterBarObject.SetActive(false);
            }
            GameCenterObject.SetActive(false);
            PreLoginObject.SetActive(true);
        }
        else
        {
            GameCenterBarObject.SetActive(true);
            GameCenterObject.SetActive(true);
            PreLoginObject.SetActive(false);
        }
    }

    protected override void RegistCustomEvent()
    {
        EventDelegate.Set(_view.IconBtn.onClick, OnIcon);
        EventDelegate.Set(_view.AccountBtn.onClick, OnAccount);
        EventDelegate.Set(_view.BackBtn.onClick, OnBack);
    }

    public void OnIcon()
    {
        SetExpand(!_isExpand);
    }

    public void OnAccount()
    {
        if (SdkModuleMgr.Instance.IsModuleOpen(SdkGameCenterView.NAME))
        {
            SdkProxyModule.ClearModule();
        }
        else
        {
            SdkProxyModule.OpenGameCenter();
        }
    }

    public void OnBack()
    {
        SetExpand(false);
    }

    public void SetExpand(bool bExpand)
    {
        if (_isExpand == bExpand) return;

        _isExpand = bExpand;
        Vector3 scale = bExpand ? new Vector3(1f, 1f, 1f) : new Vector3(0f, 1f, 1f);
        var com = TweenScale.Begin(_view.BarTrans.gameObject, 0.5f, scale);
        com.method = UITweener.Method.Linear;
    }
}