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
                break;
            case PlayerState.PLAYERSTATE.ATTACK_ONE:
                //TODO 播放动画
                break;
            case PlayerState.PLAYERSTATE.ATTACK_TWO:
                //TODO 设置状态 播放动画
                break;
            case PlayerState.PLAYERSTATE.ATTACK_THREE:
                break;
            case PlayerState.PLAYERSTATE.ATTACKRUN:
                break;
            case PlayerState.PLAYERSTATE.ATTACKJUMP:
                break;
            case PlayerState.PLAYERSTATE.SKILL:
                break;
            case PlayerState.PLAYERSTATE.DIE:
                break;
            case PlayerState.PLAYERSTATE.HIT:
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
