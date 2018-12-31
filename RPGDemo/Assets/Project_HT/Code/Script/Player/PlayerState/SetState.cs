using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Wait for me, I don't want to let you down
//love you into disease, but no medicine can.
//Created By HeXiaoTao
public class SetState
{
    private BaseState _state;
    // Use this for initialization
    public SetState()
    {
        _state = new IdleState(this);
    }
    public void SetNewState(BaseState state)
    {
        _state = state;
    }
    public void Update()
    {
        _state.AnimationChange();
    }
}
