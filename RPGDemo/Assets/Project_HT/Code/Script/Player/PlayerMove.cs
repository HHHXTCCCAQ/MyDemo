using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Wait for me, I don't want to let you down
//love you into disease, but no medicine can.
//Created By HeXiaoTao

[RequireComponent(typeof(PlayerState))]
public class PlayerMove : MonoBehaviour
{


    public float MoveSpeed = 5f;
    public float RunSpeed = 10f;

    private PlayerState Playerstate;
    private Transform PlayerTrans;
    // Use this for initialization
    void Start()
    {
        Playerstate = GetComponent<PlayerState>();
        PlayerTrans = GetComponent<Transform>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        KeyBoardMove();

    }

    public void KeyBoardMove()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (PlayerTrans != null)
                PlayerTrans.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);
            Playerstate.SetState(PlayerState.PLAYERSTATE.WALK);
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (PlayerTrans != null)
                PlayerTrans.Translate(Vector3.left * MoveSpeed * Time.deltaTime);
            Playerstate.SetState(PlayerState.PLAYERSTATE.WALK);
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (PlayerTrans != null)
                PlayerTrans.Translate(Vector3.back * MoveSpeed * Time.deltaTime);
            Playerstate.SetState(PlayerState.PLAYERSTATE.WALK);
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (PlayerTrans != null)
                PlayerTrans.Translate(Vector3.right * MoveSpeed * Time.deltaTime);
            Playerstate.SetState(PlayerState.PLAYERSTATE.WALK);
        }
    }
}
