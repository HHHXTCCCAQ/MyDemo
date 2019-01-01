using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Wait for me, I don't want to let you down
//love you into disease, but no medicine can.
//Created By HeXiaoTao
public class RunState : BaseState
{

    SetState _setState;
    public RunState(SetState state)
    {
        _setState = state;
        Debug.Log("进入Run.........");
    }
    public void AnimationChange()
    {
        switch (Config.PlayerState.State)
        {
            case PlayerState.PLAYERSTATE.IDLE:
                _setState.SetNewState(new IdleState(_setState));
                break;
            case PlayerState.PLAYERSTATE.JUMP:
                _setState.SetNewState(new JumpState(_setState));
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
