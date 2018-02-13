﻿using UnityEngine;

namespace Fish
{
    public class TweenPlayCtl:BattlePlayCtlBasic
    {
        private readonly float duaration;
        private readonly Vector3 pos;
        private readonly MonsterController mc;

        public TweenPlayCtl(MonsterController mc, Vector3 pos, float duaration)
        {
            this.mc = mc;
            this.pos = pos;
            this.duaration = duaration;
        }

        protected override IPlayFinishedState GenFinishedState()
        {
            var started = IsStarted();
            var errCode = !started
                ? PlayErrState.NotStarted
                : mc == null
                ? PlayErrState.Exception
                : CurrentProgress() < duaration
                ? PlayErrState.NotFinished
                : PlayErrState.Success;
            return new SimplePlayFinishedState(errCode);
        }

        public override float Duaration()
        {
            return duaration;
        }

        protected override void CustomStart()
        {
            mc.DoMove(pos, duaration);
        }
    }
}