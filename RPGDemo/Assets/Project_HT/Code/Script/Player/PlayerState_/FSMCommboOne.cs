using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Wait for me, I don't want to let you down
//love you into disease, but no medicine can.
//Created By HeXiaoTao
public class FSMCommboOne : FSMBaseState {

    private Animator animator;
    private float stayTime=0;
    private float stayMax = 1f;
    private PlayerStateContraller _playerStateContraller;
    public FSMCommboOne(Animator animator,PlayerStateContraller playerStateContraller)
    {
        this.animator = animator;
        _playerStateContraller = playerStateContraller;
    }

    public override void OnEnter()
    {
        animator.SetTrigger(Config.Attack);
    }

    public override void OnExit()
    {

    }

    public override void OnStay()
    {
        stayTime += Time.deltaTime;
        if (stayTime > stayMax)
        {
            _playerStateContraller.ChangeState((int)PlayerStateContraller.TURNSTATE.ATTACKSTANDY);
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.M))
            {
                Debug.Log(1);
                _playerStateContraller.ChangeState((int)PlayerStateContraller.TURNSTATE.ATTACK_TWO);
            }
        }
    }
}
