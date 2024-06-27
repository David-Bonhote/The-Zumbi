using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToTarget
{
    // olha para alvos

   public void LookAtTarget(Transform body, Vector3 target)
    {
    
        Vector2 direction = new Vector2
            (
            target.x - body.position.x,
            target.y - body.position.y
            );

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90;       //Matematica da rotação
        body.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }

}
