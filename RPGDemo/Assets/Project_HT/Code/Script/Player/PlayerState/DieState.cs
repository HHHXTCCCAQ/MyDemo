using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Wait for me, I don't want to let you down
//love you into disease, but no medicine can.
//Created By HeXiaoTao
public class DieState : BaseState
{
    SetState _setState;
    public DieState(SetState setState)
    {
        _setState = setState;
        Debug.Log("死亡");
    }
    public void AnimationChange()
    {
      
    }

    public void Update()
    {
        
    }
}
