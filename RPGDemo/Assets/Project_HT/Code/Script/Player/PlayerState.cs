﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Wait for me, I don't want to let you down
//love you into disease, but no medicine can.
//Created By HeXiaoTao
public class PlayerState : MonoBehaviour {
    public PLAYERSTATE State = PLAYERSTATE.IDLE;

    public void SetState(PLAYERSTATE state)
    {
        State = state;
    }
    public enum PLAYERSTATE
    {
        IDLE,
        ATTACKSTANDY,
        WALK,
        RUN,
        JUMP,
        ATTACKRUN,
        ATTACKJUMP,
        ATTACK_ONE,
        ATTACK_TWO,
        ATTACK_THREE,
        SKILL,
        HIT,
        DIE
    }   
}
