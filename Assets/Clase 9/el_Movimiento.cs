using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class el_Movimiento : MonoBehaviour
{
    public float downAccel = 1f;
    public float animConst = 0.02f;
    public Animator animator;
    public CharacterController charController;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        charController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {   

        charController.Move(Vector3.down * downAccel * Time.deltaTime);
        //animator.SetFloat("Vertical", 0);
        //animator.SetFloat("Horizontal", 0);
        if (Input.GetKeyDown(KeyCode.Space)) {
            animator.SetTrigger("Roll");
        }
        if (Input.GetKey(KeyCode.I))
        {
            if (animator.GetFloat("Vertical") < 1.0f) animator.SetFloat("Vertical", animator.GetFloat("Vertical") + animConst);
        }
        else if (Input.GetKey(KeyCode.K))
        {
            if (animator.GetFloat("Vertical") > -1.0f) animator.SetFloat("Vertical", animator.GetFloat("Vertical") - animConst);
        }
        else
        {
            if (animator.GetFloat("Vertical") > 0) animator.SetFloat("Vertical", animator.GetFloat("Vertical") - animConst);
            else if (animator.GetFloat("Vertical") < 1.0f) animator.SetFloat("Vertical", animator.GetFloat("Vertical") + animConst);
        }
        
        //Horizontal
        if (Input.GetKey(KeyCode.L)) 
        {
            if (animator.GetFloat("Horizontal") > -1.0f) animator.SetFloat("Horizontal", animator.GetFloat("Horizontal") - animConst);
        }
        else if(Input.GetKey(KeyCode.J))
        {
            if (animator.GetFloat("Horizontal") < 1.0f) animator.SetFloat("Horizontal", animator.GetFloat("Horizontal") + animConst);
        }
        else
        {
            if (animator.GetFloat("Horizontal") > 0) animator.SetFloat("Horizontal", animator.GetFloat("Horizontal") - animConst);
            else if (animator.GetFloat("Horizontal") < 1.0f) animator.SetFloat("Horizontal", animator.GetFloat("Horizontal") + animConst);
        }

    }   
}
