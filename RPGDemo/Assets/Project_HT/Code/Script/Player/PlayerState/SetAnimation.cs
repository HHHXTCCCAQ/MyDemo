using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Wait for me, I don't want to let you down
//love you into disease, but no medicine can.
//Created By HeXiaoTao
public class SetAnimation : MonoBehaviour
{
    public static SetAnimation _instance;
    // Use this for initialization
    private Animator _palyerAnimator;
    void Start()
    {
        _instance = this;
        _palyerAnimator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    #region 设置动画
    public void SetPlayerAnimation(string animationName, int value)
    {
        _palyerAnimator.SetInteger(animationName, value);
    }
    public void SetPlayerAnimation(string triggerName)
    {
        _palyerAnimator.SetTrigger(triggerName);
    }
    public void SetPlayerAnimation(string animationName, bool value)
    {
        _palyerAnimator.SetBool(animationName, value);

    }
    public void SetPlayerAnimation(string animationName, float value)
    {
        _palyerAnimator.SetFloat(animationName, value);
    }
    #endregion


}
