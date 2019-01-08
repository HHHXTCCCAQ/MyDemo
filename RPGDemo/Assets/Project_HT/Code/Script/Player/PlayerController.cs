using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Wait for me, I don't want to let you down
//love you into disease, but no medicine can.
//Created By HeXiaoTao
public class PlayerController : MonoBehaviour
{
    public SetState setState;
    public bool isAttack = false;
    public float MoveSpeed = 5f;
    private Transform PlayerTrans;
    private Rigidbody _rigidbody;
    private bool isGround = true;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        PlayerTrans = GetComponent<Transform>();
        Config.PlayerState = GetComponent<PlayerState>();
        setState = new SetState();
    }

    // Update is called once per frame
    void Update()
    {
        setState.Update();

        Debug.Log(IsGround());
    }

    void FixedUpdate()
    {
        PlayerKeyboardController();
        RecoverIdle();
    }

    private void PlayerKeyboardController()
    {
        //if (Input.GetKey(KeyCode.W))
        //{
        //    if (PlayerTrans != null)
        //        _rigidbody.velocity = new Vector3(MoveSpeed, _rigidbody.velocity.y, _rigidbody.velocity.z);
        //        PlayerTrans.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    if (PlayerTrans != null)
        //        PlayerTrans.Translate(Vector3.left * MoveSpeed * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    if (PlayerTrans != null)
        //        PlayerTrans.Translate(Vector3.back * MoveSpeed * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    if (PlayerTrans != null)
        //        PlayerTrans.Translate(Vector3.right * MoveSpeed * Time.deltaTime);
        //}
        float horizontal = Input.GetAxis("Horizontal"); //左右移动
        float vertical = Input.GetAxis("Vertical");//上下移动
        transform.Rotate(new Vector3(0, 1, 0) * horizontal);
        _rigidbody.velocity = new Vector3(transform.forward.x*MoveSpeed * vertical,
           transform.forward.y, transform.forward.z );


        if (IsGround())
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (!isAttack)
                {
                    Debug.Log(1);
                    Config.PlayerState.SetState(PlayerState.PLAYERSTATE.JUMP);
                }
                else
                {
                    Config.PlayerState.SetState(PlayerState.PLAYERSTATE.ATTACKJUMP);
                }
            }
        }

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

    /// <summary>
    /// 回到idle状态
    /// </summary>
    private void RecoverIdle()
    {
        SetAnimation._instance.SetPlayerAnimation(Config.PlayerSpeed, Mathf.Abs(_rigidbody.velocity.x));
        //if (_rigidbody.velocity.magnitude > 0f)
        //{
        //    if (!isAttack)
        //    {
        //        Config.PlayerState.SetState(PlayerState.PLAYERSTATE.RUN);
        //    }
        //    else
        //    {
        //        Config.PlayerState.SetState(PlayerState.PLAYERSTATE.ATTACKRUN);
        //    }
        //}
        //if (IsGround())
        //{
        //    //if (_rigidbody.velocity.magnitude <= 0f)
        //    //{
        //    //    if (!IsGround())
        //    //        return;
        //    //    if (!isAttack)
        //    //    {
        //    //        Config.PlayerState.SetState(PlayerState.PLAYERSTATE.IDLE);
        //    //    }
        //    //    else
        //    //    {
        //    //        Config.PlayerState.SetState(PlayerState.PLAYERSTATE.ATTACKSTANDY);
        //    //    }
        //    //}
        //}
    }
}
