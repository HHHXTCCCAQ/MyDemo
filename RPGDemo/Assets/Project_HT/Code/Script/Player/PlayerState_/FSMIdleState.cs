using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Wait for me, I don't want to let you down
//love you into disease, but no medicine can.
//Created By HeXiaoTao
public class FSMIdleState : FSMBaseState
{

    private Animator animator;
    private PlayerStateContraller _playerStateContraller;
    public FSMIdleState(Animator animator, PlayerStateContraller playerStateContraller)
    {
        this.animator = animator;
        _playerStateContraller = playerStateContraller;
    }

    public override void OnEnter()
    {
        Debug.Log("enter idle");
        animator.SetBool(Config.Idle, true);
    }

    public override void OnExit()
    {
        animator.SetBool(Config.Idle, false);
    }

    public override void OnStay()
    {
        if (_playerStateContraller.move)
        {
            _playerStateContraller.ChangeState((int)PlayerStateContraller.TURNSTATE.RUN);
        }
        if (_playerStateContraller.jumping)
        {
            _playerStateContraller.jumping = !_playerStateContraller.jumping;
            _playerStateContraller.ChangeState((int)PlayerStateContraller.TURNSTATE.JUMP);
        }
    }
}
