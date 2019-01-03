using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Wait for me, I don't want to let you down
//love you into disease, but no medicine can.
//Created By HeXiaoTao
public class DamageState : BaseState
{
    SetState _setState;
    public DamageState(SetState setState)
    {
        _setState = setState;
        Config.PlayerState.SetState(PlayerState.PLAYERSTATE.ATTACKSTANDY);
        Debug.Log("被攻击了");
    }
    public void AnimationChange()
    {
        switch (Config.PlayerState.State)
        {
            case PlayerState.PLAYERSTATE.ATTACKSTANDY:
                _setState.SetNewState(new AttackStandyState(_setState));
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
