﻿// **********************************************************************
// Copyright (c)  Baoyugame. All rights reserved.
// File     :  CrewSkillWindowController.cs
// the file is generated by tools
// **********************************************************************

using System;
using UniRx;


public partial class CrewSkillWindowController:MonolessViewController<CrewSkillWindow>, ICrewSkillWindowController
{
    //机器自动生成的事件绑定
    protected override void InitReactiveEvents(){
        bigBG_UIButtonEvt = View.bigBG_UIButton.AsObservable();

    }

    protected override void ClearReactiveEvents(){
        bigBG_UIButtonEvt = bigBG_UIButtonEvt.CloseOnceNull();

    }

    private Subject<Unit> bigBG_UIButtonEvt;
    public UniRx.IObservable<Unit> OnbigBG_UIButtonClick{
        get {return bigBG_UIButtonEvt;}
    }


}