﻿// **********************************************************************
// Copyright (c)  Baoyugame. All rights reserved.
// File     :  GuildItemController.cs
// the file is generated by tools
// **********************************************************************


using UniRx;

public partial interface IGuildItemController
{
     UniRx.IObservable<Unit> OnGuildItem_UIButtonClick{get;}

}

public partial class GuildItemController:MonolessViewController<GuildItem>, IGuildItemController
{
    //机器自动生成的事件绑定
    protected override void InitReactiveEvents(){
        GuildItem_UIButtonEvt = View.GuildItem_UIButton.AsObservable();

    }

    protected override void ClearReactiveEvents(){
        GuildItem_UIButtonEvt = GuildItem_UIButtonEvt.CloseOnceNull();

    }

    private Subject<Unit> GuildItem_UIButtonEvt;
    public UniRx.IObservable<Unit> OnGuildItem_UIButtonClick{
        get {return GuildItem_UIButtonEvt;}
    }


}