﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Wait for me, I don't want to let you down
//love you into disease, but no medicine can.
//Created By HeXiaoTao
public class PlayerStateContraller : MonoBehaviour
{
    public enum TURNSTATE
    {
        IDLE,
        RUN,
        JUMP,
        ATTACKSTANDY,
        WALK,
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

    public float MoveSpeed = 5f;
    private PlayerState Playerstate;
    private CharacterController characterController;
    [HideInInspector] public bool isAttack = false;
    [HideInInspector] public bool jumping = false;
    [HideInInspector] public bool move = false;
    // Use this for initialization
    void Start()
    {
        Playerstate = GetComponent<PlayerState>();
        characterController = this.GetComponent<CharacterController>();
        _playerAnimator = this.GetComponent<Animator>();
        Init();
        if (fSMManager != null)
        {
            fSMManager.ChangeState((int)TURNSTATE.IDLE);
        }

    }
    void Init()
    {
        fSMManager = new FSMManager((int)TURNSTATE.MAX);
        FSMIdleState idleState = new FSMIdleState(_playerAnimator, this);
        fSMManager.AddState(idleState);
        FSMRunState runState = new FSMRunState(_playerAnimator, this);
        fSMManager.AddState(runState);
        FSMJumpState jumpState = new FSMJumpState(_playerAnimator,this);
        fSMManager.AddState(jumpState);
    }
    // Update is called once per frame
    void Update()
    {
        fSMManager.Stay();
    }
    private void FixedUpdate()
    {
        KeyBoardMove();
    }
    /// <summary>
    /// 更换状态
    /// </summary>
    /// <param name="stateCount"></param>
    public void ChangeState(sbyte stateCount)
    {
        fSMManager.ChangeState(stateCount);
    }
    /// <summary>
    /// 键盘移动
    /// </summary>
    public void KeyBoardMove()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward);//前后移动
        float curSpeed = MoveSpeed * Input.GetAxis("Vertical");
        characterController.SimpleMove(forward * curSpeed);
        Vector3 v = transform.TransformDirection(Vector3.right);//左右移动
        float vSpeed = MoveSpeed * Input.GetAxis("Horizontal");
        characterController.SimpleMove(v * vSpeed);
        if (characterController.isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                jumping = true;
            }
        }
        //if (Input.GetKey(KeyCode.W))
        //{

        //}else if(Input.GetKey(KeyCode.A))
        //{

        //}else if (Input.GetKey(KeyCode.S))
        //{

        //}else if (Input.GetKey(KeyCode.D))
        //{

        //}
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            move = true;
        }
        else
        {
            move = false;
        }
    }
}
