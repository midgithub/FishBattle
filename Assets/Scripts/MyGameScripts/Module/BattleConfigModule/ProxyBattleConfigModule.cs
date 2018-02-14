﻿// **********************************************************************
// Copyright (c) 2016 Baoyugame. All rights reserved.
// Author : MarsZ
// Created : 03/30/2017 15:27:36
// Desc	: Auto generated by MarsZ. update this if need.
// **********************************************************************

using UnityEngine;

/// <summary>
/// This is the proxy class for module BattleAutoConfig, use this to show or hide this module.
/// @MarsZ in 03/30/2017 15:27:36
/// </summary>
public static class ProxyBattleConfigModule
{
    #region 自动设置

    public static void OpenAutoConfig()
    {
        var controller = UIModuleManager.Instance.OpenFunModule<BattleAutoConfigController>(BattleAutoConfigView.NAME, UILayerType.DefaultModule, true, true);
        controller.Open();
    }

    public static void HideAutoConfig()
    {
        UIModuleManager.Instance.HideModule(BattleAutoConfigView.NAME); 
    }

    public static void CloseAutoConfig()
    {
        UIModuleManager.Instance.CloseModule(BattleAutoConfigView.NAME);
    }

    #endregion

    #region 自动技能设置

    public static void OpenAutoSkillConfig(BattleAutoSkillConfigController.BattleConfigSkillType pSkillType)
    {
        var controller = UIModuleManager.Instance.OpenFunModule<BattleAutoSkillConfigController>(BattleAutoSkillConfigView.NAME, UILayerType.SubModule, true, true);
        controller.Open(pSkillType);
    }

    public static void HideAutoSkillConfig()
    {
        UIModuleManager.Instance.HideModule(BattleAutoSkillConfigView.NAME); 
    }

    public static void CloseAutoSkillConfig()
    {
        UIModuleManager.Instance.CloseModule(BattleAutoSkillConfigView.NAME);
    }

    #endregion

    #region 自动召唤设置

    public static void OpenAutoSummonConfig()
    {
        var controller = UIModuleManager.Instance.OpenFunModule<BattleAutoSummonConfigController>(BattleAutoSummonConfigView.NAME, UILayerType.SubModule, true, true);
        controller.Open();
    }

    public static void HideAutoSummonConfig()
    {
        UIModuleManager.Instance.HideModule(BattleAutoSummonConfigView.NAME); 
    }

    public static void CloseAutoSummonConfig()
    {
        UIModuleManager.Instance.CloseModule(BattleAutoSummonConfigView.NAME);
    }

    #endregion


}