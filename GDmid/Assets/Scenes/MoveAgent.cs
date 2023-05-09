using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAgent : MonoBehaviour
{
    UnityEngine.AI.NavMeshAgent agent;
    private Camera cam;

    private Ray ray;
    private RaycastHit hit;

    private void Awake()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        cam = Camera.main;
    }

    private void Update()
    {
        //cam follow player
        cam.transform.position = new Vector3(transform.position.x, transform.position.y +20, transform.position.z);
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
        }
    }
}
