using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Wait for me, I don't want to let you down
//love you into disease, but no medicine can.
//Created By HeXiaoTao
public class FSMAttackJumpState : FSMBaseState {

    private Animator animator;
    private AnimatorStateInfo animatorInfo;
    private PlayerStateContraller _playerStateContraller;
    public FSMAttackJumpState(Animator animator, PlayerStateContraller playerStateContraller)
    {
        this.animator = animator;
        _playerStateContraller = playerStateContraller;
    }
    public override void OnEnter()
    {
        Debug.Log("enter jump");
        animator.SetTrigger(Config.AttackJump);
    }

    public override void OnExit()
    {

        Debug.Log("exit jump");
    }

    public override void OnStay()
    {
        if (IsEnter())
        {
            _playerStateContraller.ChangeState((int)PlayerStateContraller.TURNSTATE.ATTACKSTANDY);
        }
    }
    /// <summary>
    /// 判断动画是否播放完毕
    /// </summary>
    /// <returns></returns>
    private bool IsEnter()
    {
        animatorInfo = animator.GetCurrentAnimatorStateInfo(0);
        if ((animatorInfo.normalizedTime > 0.8f))
        {
            return true;
        }
        return false;
    }
}
