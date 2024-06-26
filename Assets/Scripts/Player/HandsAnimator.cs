using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandsAnimator : MonoBehaviour
{

    [SerializeField]
    private Animator m_Animator;
    public GameObject left_effect;
    public GameObject right_effect;


   
    void Start()
    {
        m_Animator = GetComponent<Animator>();
    }


    void Update()
    {
        MouseClickBehaviour();
    }

    private void MouseClickBehaviour()
    {
        if (Input.GetMouseButtonDown(0))
        {
            left_effect.SetActive(true);
            right_effect.SetActive(true);
            m_Animator.Play("Atackplaceholder", -1, 0);

        }
    }

    public void OnAnimEnd()//----------------   Evento usado ao acabar a animação
    {
        left_effect.SetActive(false);
        right_effect.SetActive(false);
    }
    public void OnAnimStart()//--------------   Evento usado ao começar a animação
    {
        left_effect.SetActive(true);
        right_effect.SetActive(true);
    }
}
