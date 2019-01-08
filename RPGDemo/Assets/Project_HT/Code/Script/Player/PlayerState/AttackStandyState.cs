using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Wait for me, I don't want to let you down
//love you into disease, but no medicine can.
//Created By HeXiaoTao
public class AttackStandyState : BaseState
{

    SetState _setState;
    public AttackStandyState(SetState setState)
    {
        _setState = setState;
        Debug.Log("进入攻击状态");
    }
    public void AnimationChange()
    {
        switch (Config.PlayerState.State)
        {
            case PlayerState.PLAYERSTATE.IDLE:
                _setState.SetNewState(new IdleState(_setState));
                break;
            case PlayerState.PLAYERSTATE.ATTACK_ONE:
                _setState.SetNewState(new AttackCombolOne(_setState));
                //TODO 播放动画
                break;
            case PlayerState.PLAYERSTATE.ATTACKRUN:
                _setState.SetNewState(new AttackRunState(_setState));
                break;
            case PlayerState.PLAYERSTATE.ATTACKJUMP:
                _setState.SetNewState(new AttackJumpState(_setState));
                break;
            case PlayerState.PLAYERSTATE.SKILL:
                _setState.SetNewState(new SkillState(_setState));
                break;
            case PlayerState.PLAYERSTATE.DIE:
                _setState.SetNewState(new DieState(_setState));
                break;
            case PlayerState.PLAYERSTATE.HIT:
                _setState.SetNewState(new DamageState(_setState));
                break;
            default:
                break;
        }
    }

    public void Update()
    {
        throw new System.NotImplementedException();
    }
}
