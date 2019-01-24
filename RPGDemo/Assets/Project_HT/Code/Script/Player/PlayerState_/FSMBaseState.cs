using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Wait for me, I don't want to let you down
//love you into disease, but no medicine can.
//Created By HeXiaoTao
public abstract class FSMBaseState{
    /// <summary>
    /// 进入状态
    /// </summary>
    public abstract void OnEnter();
    /// <summary>
    /// 保持状态
    /// </summary>
    public abstract void OnStay();
    /// <summary>
    /// 退出状态
    /// </summary>
    public abstract void OnExit();
    
}
