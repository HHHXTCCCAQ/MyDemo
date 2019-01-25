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
    private CharacterController characterController;
    private PlayerStateContraller playerStateContraller;
    public bool isAttack = false;
    // Use this for initialization
    void Start()
    {
        Playerstate = GetComponent<PlayerState>();
        PlayerTrans = GetComponent<Transform>();
        characterController = this.GetComponent<CharacterController>();
        playerStateContraller = this.GetComponent<PlayerStateContraller>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        KeyBoardMove();
        Debug.Log(1);
    }

    public void KeyBoardMove()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward);//前后移动
        float curSpeed = MoveSpeed * Input.GetAxis("Vertical");
        characterController.SimpleMove(forward * curSpeed);
        Vector3 v = transform.TransformDirection(Vector3.right);//左右移动
        float vSpeed = MoveSpeed * Input.GetAxis("Horizontal");
        characterController.SimpleMove(v * vSpeed);
        Vector3 ve = new Vector3(-curSpeed, 0, -vSpeed);
        
        transform.rotation = Quaternion.LookRotation(new Vector3(-curSpeed, 0, -vSpeed));
    }

    private bool IsGround()
    {
        bool isGround = false;
        Debug.DrawRay(transform.position, Vector2.down, Color.red);
        RaycastHit hit;
        Physics.Raycast(transform.position, Vector2.down, out hit, 0.15f, 1 << 9);
        if (hit.collider != null)
        {
            isGround = true;
        }
        else
        {
            isGround = false;
        }
        return isGround;
    }
}
