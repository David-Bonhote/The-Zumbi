using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField]
    private RotateToTarget olharParaMouse = new RotateToTarget();
    private MoveWithInput controlMove = new MoveWithInput();
    private Rigidbody2D myRigidBody;

    private Vector3 mouse_Pos;

    private float speed = 5f;

    private Transform corpo;


    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        corpo = gameObject.transform.GetChild(0);
        Debug.Log(corpo);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        mouse_Pos = Input.mousePosition;
        mouse_Pos = Camera.main.ScreenToWorldPoint(mouse_Pos);
        
        olharParaMouse.LookAtTarget(corpo, mouse_Pos);
        controlMove.DiretionalInput(myRigidBody, speed);
    }

   
}
