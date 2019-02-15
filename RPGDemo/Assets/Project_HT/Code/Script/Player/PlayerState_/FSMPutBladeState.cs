using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Wait for me, I don't want to let you down
//love you into disease, but no medicine can.
//Created By HeXiaoTao
public class FSMPutBladeState : FSMBaseState {

    private Animator animator;
    private PlayerStateContraller _playerStateContraller;
    private float stayTime = 0f;
    private float stayMax = 0.3f;
    public FSMPutBladeState(Animator animator,PlayerStateContraller playerStateContraller)
    {
        this.animator = animator;
        _playerStateContraller = playerStateContraller;
    }

    public override void OnEnter()
    {
        animator.SetTrigger(Config.PutBlade);
    }

    public override void OnExit()
    {

    }

    public override void OnStay()
    {
        stayTime += Time.deltaTime;
        if (stayTime > stayMax)
            _playerStateContraller.ChangeState((int)PlayerStateContraller.TURNSTATE.IDLE);


    }
}
