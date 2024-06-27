using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AttackBehaviour : MonoBehaviour
{
    [SerializeField]
    private bool isReady;
    private Transform player;
    private float coolDown = 0.5f;
    private Animator m_Animator;


    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Jogador").transform;
        m_Animator = GetComponent<Animator>();
    }


    void FixedUpdate()
    {
        coolDown -= Time.fixedDeltaTime;
        if (coolDown <= 0)
        {
            isReady = true;
        }
        AttackPlayer();
    }

    private void AttackPlayer()
    {

        float distance = Vector2.Distance(transform.position, player.transform.position);
        if (distance < 2.2f && isReady == true)
        {
            m_Animator.Play("AtkPlaceHolder", -1, 0);
        }
    }

    public void OnAttackEnter()
    {
        isReady = false;
        coolDown = 0.5f;
    }

    public void OnAttackExit()
    {
        
        Debug.Log($" o CD é:  {coolDown}");
        if(coolDown <= 0)
        {
            isReady = true;
        }
        //isReady = true;
    }
}
