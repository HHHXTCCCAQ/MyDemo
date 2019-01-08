using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Wait for me, I don't want to let you down
//love you into disease, but no medicine can.
//Created By HeXiaoTao
public class JumpState : BaseState
{
    SetState _setState;
    private float time;
    public JumpState(SetState setState)
    {
        _setState = setState;
        Debug.Log("进入跳跃状态。。。");
    }
    public void AnimationChange()
    {
        time += Time.deltaTime;
        if (time >= 0.5f)
            Config.PlayerState.SetState(PlayerState.PLAYERSTATE.IDLE);
        switch (Config.PlayerState.State)
        {
            case PlayerState.PLAYERSTATE.IDLE:
                _setState.SetNewState(new IdleState(_setState));
                SetAnimation._instance.SetPlayerAnimation(Config.Idle, true);
                break;
            case PlayerState.PLAYERSTATE.RUN:
                _setState.SetNewState(new RunState(_setState));
                SetAnimation._instance.SetPlayerAnimation(Config.Run, true);
                SetAnimation._instance.SetPlayerAnimation(Config.PlayerSpeed, 0.6f);
                break;
            case PlayerState.PLAYERSTATE.DIE:
                _setState.SetNewState(new DieState(_setState));
                SetAnimation._instance.SetPlayerAnimation(Config.Die, true);
                break;
            case PlayerState.PLAYERSTATE.HIT:
                _setState.SetNewState(new DamageState(_setState));
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
