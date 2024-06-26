using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBodyRotation : MonoBehaviour
{

    
    void Update()
    {
        LookAtMouse(); 
    }
    private void LookAtMouse() //Faz o personagem olhar para o mouse todo tempo
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2
            (
            mousePosition.x - transform.position.x,
            mousePosition.y - transform.position.y
            );

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90;       //Matematica da rotação
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));                //Aplicação da rotação
    }
}
