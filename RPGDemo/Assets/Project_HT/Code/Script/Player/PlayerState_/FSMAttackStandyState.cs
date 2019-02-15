using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Wait for me, I don't want to let you down
//love you into disease, but no medicine can.
//Created By HeXiaoTao
public class FSMAttackStandyState : FSMBaseState {

    private Animator animator;
    private PlayerStateContraller _playerStateContraller;
    public FSMAttackStandyState(Animator animator,PlayerStateContraller playerStateContraller)
    {
        this.animator = animator;
        _playerStateContraller = playerStateContraller;
    }

    public override void OnEnter()
    {
        Debug.Log("Enter attack standy");
        animator.SetBool(Config.AttackStandy, true);
    }

    public override void OnExit()
    {
        animator.SetBool(Config.AttackStandy, false);
    }

    public override void OnStay()
    {
        if (_playerStateContraller.move)
        {
            _playerStateContraller.ChangeState((int)PlayerStateContraller.TURNSTATE.ATTACKRUN);
        }
        if (_playerStateContraller.jumping)
        {
            _playerStateContraller.jumping = !_playerStateContraller.jumping;
            _playerStateContraller.ChangeState((int)PlayerStateContraller.TURNSTATE.ATTACKJUMP);
        }
        if (_playerStateContraller.attack)
        {
            _playerStateContraller.attack = !_playerStateContraller.attack;
            _playerStateContraller.ChangeState((int)PlayerStateContraller.TURNSTATE.ATTACK_ONE);
        }
    }
}
