using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Wait for me, I don't want to let you down
//love you into disease, but no medicine can.
//Created By HeXiaoTao
public class IdleState : BaseState
{
    SetState _setState;
    public IdleState(SetState setState)
    {
        _setState = setState;
        Debug.Log("Idle 状态。。。。。");
        //TODO 更新状态
    }

    public void AnimationChange()
    {
        switch (Config.PlayerState.State)
        {
            case PlayerState.PLAYERSTATE.RUN:
                _setState.SetNewState(new RunState(_setState));
                SetAnimation._instance.SetPlayerAnimation(Config.Run, true);
                SetAnimation._instance.SetPlayerAnimation(Config.Idle, false);
                //SetAnimation._instance.SetPlayerAnimation(Config.PlayerSpeed, 0.6f);
                //TODO 播放动画
                break;
            case PlayerState.PLAYERSTATE.JUMP:
                _setState.SetNewState(new JumpState(_setState));
                SetAnimation._instance.SetPlayerAnimation(Config.Idle, false);
                SetAnimation._instance.SetPlayerAnimation(Config.Jump);
                //TODO 设置状态 播放动画
                break;
            case PlayerState.PLAYERSTATE.DRAWBLADE:
                _setState.SetNewState(new DrawBladeState(_setState));
                SetAnimation._instance.SetPlayerAnimation(Config.Idle, false);
                SetAnimation._instance.SetPlayerAnimation(Config.DrawBlade);
                break;
            case PlayerState.PLAYERSTATE.DIE:
                _setState.SetNewState(new DieState(_setState));
                SetAnimation._instance.SetPlayerAnimation(Config.Idle, false);
                SetAnimation._instance.SetPlayerAnimation(Config.Die, true);
                break;
            case PlayerState.PLAYERSTATE.HIT:
                _setState.SetNewState(new DamageState(_setState));
                SetAnimation._instance.SetPlayerAnimation(Config.Idle, false);
                SetAnimation._instance.SetPlayerAnimation(Config.Hit);
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    public void Update()
    {
        Debug.Log("c");
    }

}

