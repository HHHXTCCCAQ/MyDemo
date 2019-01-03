using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Wait for me, I don't want to let you down
//love you into disease, but no medicine can.
//Created By HeXiaoTao
public class PutBladeState : BaseState
{

    SetState _setState;
    public PutBladeState(SetState setState)
    {
        _setState = setState;
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
            case PlayerState.PLAYERSTATE.HIT:
                break;
            default:
                break;
        }
    }

    public void Update()
    {

    }
}
