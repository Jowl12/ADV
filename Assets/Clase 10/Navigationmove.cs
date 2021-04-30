using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Navigationmove : MonoBehaviour
{
    public Transform goal;
    UnityEngine.AI.NavMeshAgent agent;
    Animator animatorPersonaje;
    public Transform MarcaDestino;
    public Camera camara;
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        animatorPersonaje = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camara.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                agent.destination = MarcaDestino.position = hit.point;
                //MarcaDestino.GetComponent<AudioSource>().Play();
            }
        }
        if (agent.isOnOffMeshLink) { animatorPersonaje.SetTrigger("saltar"); }
        animatorPersonaje.SetFloat("Horizontal", transform.InverseTransformDirection(agent.velocity).x);
        animatorPersonaje.SetFloat("Vertical", transform.InverseTransformDirection(agent.velocity).z);
    }
}
