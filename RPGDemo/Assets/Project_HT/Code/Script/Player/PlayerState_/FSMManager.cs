using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Wait for me, I don't want to let you down
//love you into disease, but no medicine can.
//Created By HeXiaoTao
public class FSMManager{
    FSMBaseState[] fSMBaseStates;
    private int curState=0;
    private int stateIndex=-1;
    public FSMManager(int stateCount )
    {
        Init(stateCount);
    }
	private void Init(int stateCount)
    {
        fSMBaseStates = new FSMBaseState[stateCount];
    }
    /// <summary>
    /// 添加状态
    /// </summary>
    /// <param name="state"></param>
    public void AddState(FSMBaseState state)
    {
        if (curState > fSMBaseStates.Length - 1)
            return;
        fSMBaseStates[curState] = state;
        curState++;
    }
    /// <summary>
    /// 更改状态
    /// </summary>
    /// <param name="state"></param>
    public void ChangeState(int state)
    {
        if (state > fSMBaseStates.Length - 1 || state == stateIndex)
            return;
        if (stateIndex != -1)
            fSMBaseStates[stateIndex].OnExit();
        stateIndex = state;
        fSMBaseStates[stateIndex].OnEnter();

    }
    /// <summary>
    /// Update  
    /// </summary>
    public void Stay()
    {
        if (stateIndex != -1)
            fSMBaseStates[stateIndex].OnStay();
    }
}
