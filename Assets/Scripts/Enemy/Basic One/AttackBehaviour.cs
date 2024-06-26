using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AttackBehaviour : MonoBehaviour
{
    [SerializeField]
    private bool isReady;
    private BasicEnemyOneBodyRotation getDistance;
    private float myDistance;
    private float coolDown = 0.5f;
    private Animator m_Animator;


    private void Awake()
    {
        getDistance = GetComponentInParent<BasicEnemyOneBodyRotation>();
        m_Animator = GetComponent<Animator>();
       // Debug.Log("O getDistance está aparecendo : " + getDistance);
    }


    void Update()
    {
        coolDown -= Time.deltaTime;
        if (coolDown <= 0)
        {
            isReady = true;
        }
        AttackPlayer();
    }

    private void AttackPlayer()
    {
        myDistance = getDistance.distance;
        //Debug.Log(myDistance);
        if (myDistance < 2.5f && isReady == true)
        {
            m_Animator.Play("AtkPlaceHolder", -1, 0);
            //Debug.Log("Está animando!!");

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
