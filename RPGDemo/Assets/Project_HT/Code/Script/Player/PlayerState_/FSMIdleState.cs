using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Wait for me, I don't want to let you down
//love you into disease, but no medicine can.
//Created By HeXiaoTao
public class FSMIdleState :FSMBaseState {

    private Animator animator;
    private PlayerStateContraller _playerStateContraller;
    public FSMIdleState(Animator animator,PlayerStateContraller playerStateContraller)
    {
        this.animator = animator;
        _playerStateContraller = playerStateContraller;
    }

    public override void OnEnter()
    {
        animator.SetBool(Config.Idle, true);
    }

    public override void OnExit()
    {
        animator.SetBool(Config.Idle, false);
    }

    public override void OnStay()
    {
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool(Config.Run, true);
            OnExit();
        }
    }
}
