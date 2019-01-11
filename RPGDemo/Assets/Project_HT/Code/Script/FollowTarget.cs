using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Wait for me, I don't want to let you down
//love you into disease, but no medicine can.
//Created By HeXiaoTao
public class FollowTarget : MonoBehaviour {

	// Use this for initialization
    public  Vector3 Offset;
    private Transform Player;
    public float smoothing = 1;
	void Start ()
	{
	    Player = GameObject.FindGameObjectWithTag("Player").transform.Find("Bip001");
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
	    //transform.position = Player.position + Offset;
	    Vector3 targetPos = Player.position + Offset;
	  transform.position= Vector3.Lerp(transform.position, targetPos, smoothing*Time.deltaTime);
	}
}
