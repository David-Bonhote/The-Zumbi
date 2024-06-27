using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSmoothMoveScript : MonoBehaviour
{

    [SerializeField]
    private Vector3 offset;
    private Vector3 veloc = Vector3.zero;
    private float damping;

    private Transform target;



    void Start()
    {
        target = GameObject.FindWithTag("Jogador").transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 targetPos = target.position + offset;
        targetPos.z = transform.position.z;

        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref veloc, damping);
    }
}
