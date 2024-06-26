using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BasicEnemyOneBodyRotation : MonoBehaviour
{
    [SerializeField]
    
    private GameObject player;
    private bool atkReady;
    private Animator m_Animator;
    public float distance;
    public Vector2 direction;



    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Jogador");
        m_Animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        LookAtPlayer();
        MyDistanceToPlayer();
    }

    private void LookAtPlayer() //Faz o inimigo olhar para o jogador
    {
        Vector3 playerPosition = player.transform.position;
        direction = new Vector2
            (
            playerPosition.x - transform.position.x,
            playerPosition.y - transform.position.y
            );

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90;       //Matematica da rotação
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));                //Aplicação da rotação
    }
    
    private void MyDistanceToPlayer()
    {
         distance = Vector2.Distance(transform.position, player.transform.position);
                 //Debug.Log("A distancia é: " + distance);
    }

    
}
