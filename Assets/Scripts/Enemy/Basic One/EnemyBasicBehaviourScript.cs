using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyBasicBehaviourScript : MonoBehaviour
{

    [SerializeField] private GameObject player;
    [SerializeField] private RotateToTarget lookToPlayer = new RotateToTarget();
    [SerializeField] private GoToTargetScript goToPlayer = new GoToTargetScript();

    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D myRB2D;
    [SerializeField] private Transform myBody;

    [SerializeField] private int maxHealth;
    [SerializeField] private int currentHealth;
    [SerializeField] private Transform healthBar;

    [SerializeField] private float takeDamageCD;


    // Start is called before the first frame update

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Jogador");
      
        maxHealth = 3;
        currentHealth = maxHealth;
        speed = 1;
        takeDamageCD = 0.2f;
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        myMoveBehaviour();
        lookToPlayer.LookAtTarget(myBody, player.transform.position);
        takeDamageCD -= Time.fixedDeltaTime;
    }

    void myMoveBehaviour()
    {
        float distance = Vector2.Distance(myBody.position, player.transform.position);
        if (distance >= 2.2f)
        {
            goToPlayer.GoToTarget(myRB2D, player.transform.position, speed);
        }
        else if (distance <= 1.8f)
        {
            goToPlayer.GoToTarget(myRB2D, player.transform.position, -(speed + 1));
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerAtk1") && takeDamageCD <= 0)
        {
           
                currentHealth--;
                SetHealthBarNegative();
                takeDamageCD = 0.4f;
            
        }
    }

    void SetHealthBarNegative()
    {
        if (currentHealth <= 0)
        {
            healthBar.transform.localScale = new Vector3(0, 0);

        }
        else
        {
            healthBar.transform.localScale -= new Vector3(0.3f, 0);
        }

    }
}
