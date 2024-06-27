using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GoToTargetScript
{
    public void GoToTarget(Rigidbody2D myBody, Vector3 target, float speed)
    {
        Vector2 goDirection = new Vector2(target.x - myBody.position.x,
                                          target.y - myBody.position.y);

        myBody.MovePosition(myBody.position + goDirection * (speed * Time.fixedDeltaTime));
    }
    
}
