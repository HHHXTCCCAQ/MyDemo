using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Wait for me, I don't want to let you down
//love you into disease, but no medicine can.
//Created By HeXiaoTao
public class FSMDeathState : FSMBaseState {

    private Animator animator;
    private float stayTime = 0;
    private float stayMax = 0.5f;
    private PlayerStateContraller _playerStateContraller;
    public FSMDeathState(Animator animator, PlayerStateContraller playerStateContraller)
    {
        this.animator = animator;
        _playerStateContraller = playerStateContraller;
    }


    public override void OnEnter()
    {
        animator.SetTrigger(Config.Die);
        _playerStateContraller.enabled = false;
    }

    public override void OnExit()
    {

    }

    public override void OnStay()
    {

    }
}
