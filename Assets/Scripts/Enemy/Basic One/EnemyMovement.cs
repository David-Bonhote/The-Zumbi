using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    private BasicEnemyOneBodyRotation basicEnemyOneBodyRotation;

    private void Start()
    {
        basicEnemyOneBodyRotation = GetComponentInChildren<BasicEnemyOneBodyRotation>();
    }
    void Update()
    {
        GoToPlayer();
    }

    void GoToPlayer()
    {
        Vector3 vector3 = basicEnemyOneBodyRotation.direction;
        float dist = basicEnemyOneBodyRotation.distance;
        if (dist >= 2)
        {
            transform.position = transform.position + vector3 * 1 * Time.deltaTime;
        }
        else if(dist <= 1.8)
        {

            transform.position = transform.position + vector3 * -1 *Time.deltaTime;
        }    
    }
}
