using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithInput
{

    //Recebe os inputs vertical e horizontal e faz a movimentação do personagem do personagem 

    public void DiretionalInput(Rigidbody2D body, float speed)
    {
        float direcaoVertical = Input.GetAxisRaw("Vertical");
        float direcaoHorizontal = Input.GetAxisRaw("Horizontal");

        Vector2 goDirection = new Vector3(direcaoHorizontal * speed, direcaoVertical * speed) ;
        Debug.Log(goDirection);
        body.MovePosition(body.position + goDirection * Time.fixedDeltaTime);
    }
}
