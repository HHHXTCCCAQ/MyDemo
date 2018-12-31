using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Wait for me, I don't want to let you down
//love you into disease, but no medicine can.
//Created By HeXiaoTao
public class IdleState : BaseState
{
    SetState _setState;
    public IdleState(SetState setState)
    {
        _setState = setState;
        //TODO 更新状态
    }

    public void AnimationChange()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("C");
        }
    }

    // Update is called once per frame
    public void Update()
    {

    }

}
