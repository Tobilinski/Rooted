using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ClickToMove : MonoBehaviour
{
    public LayerMask layerMask;

    private NavMeshAgent myMeshAgent;

    private void Start()
    {
        myMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(myRay, out hitInfo, 100, layerMask))
            {
                myMeshAgent.SetDestination(hitInfo.point);
            }
        }
    }
}
