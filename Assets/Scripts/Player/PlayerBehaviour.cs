using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBehaviour : MonoBehaviour
{

    [SerializeField] private RotateToTarget olharParaMouse = new RotateToTarget();
    [SerializeField] private MoveWithInput controlMove = new MoveWithInput();
    [SerializeField] Rigidbody2D myRigidBody;

    [SerializeField] Vector3 mouse_Pos;

    [SerializeField] float speed = 5f;

    [SerializeField] Transform corpo;

    [SerializeField] int MaxHeath;
    [SerializeField] int currentHealth;

    [SerializeField] private PlayerHealthBehaviour healthBar = new PlayerHealthBehaviour();
    [SerializeField] private Slider slider;

    
    void Start()
    {
        MaxHeath = 10;
        healthBar.SetMaxHealth( slider ,MaxHeath);
        currentHealth = MaxHeath;

        
    }

    void FixedUpdate()
    {
        mouse_Pos = Input.mousePosition;
        mouse_Pos = Camera.main.ScreenToWorldPoint(mouse_Pos);
        
        olharParaMouse.LookAtTarget(corpo, mouse_Pos);
        controlMove.DiretionalInput(myRigidBody, speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy1"))
        {
            currentHealth--;
            healthBar.SetHealth(slider, currentHealth);
        }
    }
}
