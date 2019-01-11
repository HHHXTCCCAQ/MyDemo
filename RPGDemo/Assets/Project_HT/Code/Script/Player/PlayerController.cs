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
    private Vector3 rigVelocity;
    private Rigidbody _rigidbody;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        Config.PlayerState = GetComponent<PlayerState>();
        setState = new SetState();
    }

    // Update is called once per frame
    void Update()
    {
        setState.Update();
    }

    void FixedUpdate()
    {
        PlayerKeyboardController();
    }

    private void PlayerKeyboardController()
    {
        SetAnimation._instance.SetPlayerAnimation(Config.PlayerSpeed,
            Mathf.Max(Mathf.Abs(_rigidbody.velocity.x), Mathf.Abs(_rigidbody.velocity.z)));
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        rigVelocity = _rigidbody.velocity;
        if (Mathf.Abs(h) > 0.05f || Mathf.Abs(v) > 0.05f)
        {
            if (!isAttack)
            {
                Config.PlayerState.SetState(PlayerState.PLAYERSTATE.RUN);
            }
            else
            {
                Config.PlayerState.SetState(PlayerState.PLAYERSTATE.ATTACKRUN);
            }
            _rigidbody.velocity = new Vector3(v * MoveSpeed, rigVelocity.y, -h * MoveSpeed);
            transform.rotation = Quaternion.LookRotation(new Vector3(v, 0, -h));
        }
        else
        {
            if (!isAttack)
            {
                Config.PlayerState.SetState(PlayerState.PLAYERSTATE.IDLE);
            }
            else
            {
                Config.PlayerState.SetState(PlayerState.PLAYERSTATE.ATTACKSTANDY);
            }
        }
        if (IsGround())
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (!isAttack)
                {
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
}
