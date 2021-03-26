using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class ControlAnimaciones : MonoBehaviour
{
    public Animator animator;
    public string parametroBoolean;
    bool b = false;
    private void OnTriggerEnter(Collider other)
    {
        b = !b;
        animator.SetBool(parametroBoolean, b);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K)) animator.SetTrigger("destruir");
    }
}
