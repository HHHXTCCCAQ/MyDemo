using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Wait for me, I don't want to let you down
//love you into disease, but no medicine can.
//Created By HeXiaoTao
public class AttackRunState : BaseState {

    SetState _setState;
    public AttackRunState(SetState state)
    {
        _setState = state;
        Debug.Log("进入Run.........");
    }
    public void AnimationChange()
    {
        switch (Config.PlayerState.State)
        {
            case PlayerState.PLAYERSTATE.ATTACKSTANDY:
                _setState.SetNewState(new AttackStandyState(_setState));
                break;
            case PlayerState.PLAYERSTATE.ATTACKJUMP:
                _setState.SetNewState(new AttackJumpState(_setState));
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
