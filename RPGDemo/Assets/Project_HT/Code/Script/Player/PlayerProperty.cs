using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Wait for me, I don't want to let you down
//love you into disease, but no medicine can.
//Created By HeXiaoTao
public class PlayerProperty : MonoBehaviour,HealthSystem {
    public int _hp = 100;
    public int hpMax = 100;
    public void AddHP(int hp)
    {
        if (_hp >= hpMax)
            return;
        _hp += hp;
    }

    public void CutHP(int hp)
    {
        if (_hp <= 0)
        {
            Death();
            return;
        }
        _hp -= hp;      
    }

    public void Death()
    {
      
    }

}
