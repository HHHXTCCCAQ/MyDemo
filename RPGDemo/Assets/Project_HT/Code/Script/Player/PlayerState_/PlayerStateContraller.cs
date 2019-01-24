using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Wait for me, I don't want to let you down
//love you into disease, but no medicine can.
//Created By HeXiaoTao
public class PlayerStateContraller : MonoBehaviour {
    public enum TURNSTATE
    {
        IDLE,
        ATTACKSTANDY,
        WALK,
        RUN,
        JUMP,
        ATTACKRUN,
        ATTACKJUMP,
        DRAWBLADE,
        PUTBLADE,
        ATTACK_ONE,
        ATTACK_TWO,
        ATTACK_THREE,
        SKILL,
        HIT,
        DIE,
        MAX
    }
    private Animator _playerAnimator;
    private FSMManager fSMManager;
	// Use this for initialization
	void Start () {
        _playerAnimator = this.GetComponent<Animator>();
        fSMManager = new FSMManager((int) TURNSTATE.IDLE);
        FSMIdleState idleState = new FSMIdleState(_playerAnimator,this);
        fSMManager.AddState(idleState);
    }
	
	// Update is called once per frame
	void Update () {
        fSMManager.Stay();
	}

    public void ChangeState( sbyte stateCount)
    {
        fSMManager.ChangeState(stateCount);
    }
}
