using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Wait for me, I don't want to let you down
//love you into disease, but no medicine can.
//Created By HeXiaoTao
public class AttackJumpState : BaseState {

    SetState _setState;

    public AttackJumpState(SetState setState)
    {
        _setState = setState;
        Debug.Log("进入跳跃状态。。。");
    }
    public void AnimationChange()
    {
        switch (Config.PlayerState.State)
        {
            case PlayerState.PLAYERSTATE.ATTACKSTANDY:
                _setState.SetNewState(new AttackStandyState(_setState));
                break;
            case PlayerState.PLAYERSTATE.ATTACKRUN:
                _setState.SetNewState(new AttackRunState(_setState));
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
