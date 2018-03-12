﻿using AppDto;

namespace Fish
{
    public class VedioActionTargetStatePlayCtl:BattlePlayCtlBasic
    {
        private VideoActionTargetState _state;
        private VideoTargetStateGroup _group;
        private CorrectSkillConfig _skillCfg;
        private Skill _skill;

        public VedioActionTargetStatePlayCtl(VideoActionTargetState videoActionTargetState,
            VideoTargetStateGroup targetStateGroup, CorrectSkillConfig skillCfg, Skill skill)
        {
            _state = videoActionTargetState;
            _group = targetStateGroup;
            _skillCfg = skillCfg;
            _skill = skill;
        }

        protected override IPlayFinishedState GenFinishedState()
        {
            var started = IsStarted();
            if (!started) return new SinglePlayFinishedState(null, PlayErrState.NotStarted);
            
            return null;
        }

        public override float Duaration()
        {
            return LessThanOneFrame;
        }

        protected override void CustomDispose()
        {
            _state = null;
            _group = null;
            _skillCfg = null;
            _skill = null;
        }

        protected override void CustomStart()
        {
            var mc = BattleDataManager.MonsterManager.Instance.GetMonsterFromSoldierID(_state.id);
            if (mc != null)
            {
                mc.ClearMessageEffect(true);
            }
            else
            {
                GameDebuger.TODO(@"if (bas is VideoCallSoldierState)
            {
                VideoCallSoldierState videoCallSoldierState = bas as VideoCallSoldierState;
                         BattleController.Instance.CallPet(videoCallSoldierState.soldier);
            }");
                return;
            }

            mc.dead = _state.dead;
            mc.leave = _state.leave;
            mc.PlayInjure(_state);
        }
    }
}