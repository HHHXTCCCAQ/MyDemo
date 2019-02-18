using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
//Wait for me, I don't want to let you down
//love you into disease, but no medicine can.
//Created By HeXiaoTao
[RequireComponent(typeof(NavMeshAgent))]
public class Enemy : MonoBehaviour
{
    public float speed;
    public float attackRang;
    public float reviveRang;//唤醒距离
    public float CritChance;//暴击几率
    public float Hp = 100;
    private float distanceToPlayer;
    private Animation enemyAnimation;
    private Transform taget;
    private NavMeshAgent agent;
    private PlayerStateContraller playerStateContraller;
    private bool isWalk;
    // Use this for initialization
    void Start()
    {
        enemyAnimation = GetComponent<Animation>();
        taget = GameObject.FindGameObjectWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();
        agent.speed = speed;
        playerStateContraller = taget.GetComponent<PlayerStateContraller>();
        //agent.SetDestination(taget.position);
    }

    // Update is called once per frame
    void Update()
    {
        distanceToPlayer = Vector3.Distance(transform.position, taget.position);
    }

    private void FixedUpdate()
    {
        EnemyAnimationPlayer();
    }

    public float randomValue = 0;
    public void EnemyAnimationPlayer()
    {
        if (Hp <= 0)
            return;

        if (distanceToPlayer > reviveRang)
        {
            enemyAnimation.Play(Config.Idle);
            if (playerStateContraller.drawBlade == true)
            {
                playerStateContraller.drawBlade = false;
            }
        }
        else if (reviveRang > distanceToPlayer && distanceToPlayer > attackRang)
        {
            isWalk = true;
            if (playerStateContraller.drawBlade == false)
            {
                playerStateContraller.drawBlade = true;
            }
            enemyAnimation.Play(Config.Run);
            agent.SetDestination(taget.position);
        }
        else
        {
            //进入攻击状态
            isWalk = false;
            enemyAnimation.Stop(Config.Run);
            randomValue = Random.Range(0, 100);
            if(randomValue/100<= CritChance)
            {              
                enemyAnimation.PlayQueued(Config.Attack2);
            }
            else
            {
                enemyAnimation.PlayQueued(Config.Attack1);
            }
            
        }
    }
}
