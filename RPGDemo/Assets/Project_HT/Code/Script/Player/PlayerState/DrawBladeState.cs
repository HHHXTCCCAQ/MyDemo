using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Wait for me, I don't want to let you down
//love you into disease, but no medicine can.
//Created By HeXiaoTao
public class DrawBladeState : BaseState
{
    SetState _setState;
    public DrawBladeState(SetState setState)
    {
        _setState = setState;
        Config.PlayerState.SetState(PlayerState.PLAYERSTATE.ATTACKSTANDY);
        Debug.Log("拔剑");
    }
    public void AnimationChange()
    {
        
        switch (Config.PlayerState.State)
        {
            case PlayerState.PLAYERSTATE.ATTACKSTANDY:
                _setState.SetNewState(new AttackStandyState(_setState));
                //TODO 播放动画
                break;
            case PlayerState.PLAYERSTATE.DIE:
                break;
            default:
                break;
        }
    }

    public void Update()
    {

    }
}
