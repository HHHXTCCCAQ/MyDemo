﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Wait for me, I don't want to let you down
//love you into disease, but no medicine can.
//Created By HeXiaoTao
public class PlayerController : MonoBehaviour
{
    public SetAnimation setAnimation;
    public SetState setState;
    // Use this for initialization
    void Start()
    {
        setState = new SetState();
    }

    // Update is called once per frame
    void Update()
    {
        setState.Update();
    }
}
