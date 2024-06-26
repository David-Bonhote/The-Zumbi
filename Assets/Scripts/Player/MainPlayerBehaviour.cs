using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayerBehaviour : MonoBehaviour
{


    [SerializeField]
    private float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
        LookAtMouse();
    }

    private void LookAtMouse()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2(
            mousePosition.x - transform.position.x,
            mousePosition.y - transform.position.y
        );

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90 ;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }

    private void PlayerMovement()
    {
        float direcaoVertical = Input.GetAxisRaw("Vertical");
        float direcaoHorizontal = Input.GetAxisRaw("Horizontal");
       
        transform.position = new Vector3(
                    transform.position.x + (direcaoHorizontal * speed) * Time.deltaTime,                                           // movimento no eixo x
                    transform.position.y + (direcaoVertical * speed) * Time.deltaTime,      // movimento no eixo y
                    transform.position.z);                                          // movimento no eixo z
                Debug.Log("A direção Vertical é : " + direcaoVertical);
                Debug.Log("A direção Horizontal é : " + direcaoHorizontal);

    }

}
