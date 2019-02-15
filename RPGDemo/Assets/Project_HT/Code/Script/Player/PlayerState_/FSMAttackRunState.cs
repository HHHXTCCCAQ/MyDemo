using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Wait for me, I don't want to let you down
//love you into disease, but no medicine can.
//Created By HeXiaoTao
public class FSMAttackRunState : FSMBaseState {

    private Animator animator;
    private PlayerStateContraller _playerStateContraller;


    public FSMAttackRunState(Animator animator, PlayerStateContraller playerStateContraller)
    {
        this.animator = animator;
        _playerStateContraller = playerStateContraller;

    }

    public override void OnEnter()
    {
        animator.SetBool(Config.AttackRun, true);
    }

    public override void OnExit()
    {
        animator.SetBool(Config.AttackRun, false);
    }

    public override void OnStay()
    {
        if (!_playerStateContraller.move)
        {
            _playerStateContraller.ChangeState((int)PlayerStateContraller.TURNSTATE.ATTACKSTANDY);
        }
        if (_playerStateContraller.jumping)
        {
            _playerStateContraller.jumping = !_playerStateContraller.jumping;
            _playerStateContraller.ChangeState((int)PlayerStateContraller.TURNSTATE.ATTACKJUMP);
        }
    }

}
