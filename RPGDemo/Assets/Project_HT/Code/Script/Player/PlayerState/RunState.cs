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
                SetAnimation._instance.SetPlayerAnimation(Config.Idle, true);
                SetAnimation._instance.SetPlayerAnimation(Config.Run, false);
                //SetAnimation._instance.SetPlayerAnimation(Config.PlayerSpeed, 0.2f);
                break;
            case PlayerState.PLAYERSTATE.JUMP:
                _setState.SetNewState(new JumpState(_setState));
                SetAnimation._instance.SetPlayerAnimation(Config.Run, false);
                SetAnimation._instance.SetPlayerAnimation(Config.Jump);
                break;
            case PlayerState.PLAYERSTATE.DIE:
                _setState.SetNewState(new DieState(_setState));
                SetAnimation._instance.SetPlayerAnimation(Config.Run, false);
                SetAnimation._instance.SetPlayerAnimation(Config.Run, true);
                break;
            case PlayerState.PLAYERSTATE.HIT:
                _setState.SetNewState(new DamageState(_setState));
                SetAnimation._instance.SetPlayerAnimation(Config.Run, false);
                SetAnimation._instance.SetPlayerAnimation(Config.Hit);
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
