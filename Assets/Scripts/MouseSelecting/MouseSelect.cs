using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseSelect : MonoBehaviour
{
    public Camera camera;
    public CamMove Script;
    

    // Update is called once per frame
    void Update()
    {
        ToScreen();
        ToBox();
        ToMaze();
    }

    private void ToScreen()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                if (hitInfo.collider.gameObject.GetComponent<Target>() != null)
                {
                    Vector3 distanceToTarget = hitInfo.point - transform.position;
                    Vector3 forceDirection = distanceToTarget.normalized;
                    Script.MoveToScreen();
                    print("hit");
                }
            }
        }


        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                if (hitInfo.collider.gameObject.GetComponent<Target>() != null)
                {
                    Vector3 distanceToTarget = hitInfo.point - transform.position;
                    Vector3 forceDirection = distanceToTarget.normalized;
                    Script.MoveFromScreen();
                    print("hit");
                }
            }
        }
    }
    private void ToBox()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                if (hitInfo.collider.gameObject.GetComponent<Target2>() != null)
                {
                    Vector3 distanceToTarget = hitInfo.point - transform.position;
                    Vector3 forceDirection = distanceToTarget.normalized;
                    Script.MoveToBox();
                    print("hitChair");
                }
            }
        }


        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                if (hitInfo.collider.gameObject.GetComponent<Target2>() != null)
                {
                    Vector3 distanceToTarget = hitInfo.point - transform.position;
                    Vector3 forceDirection = distanceToTarget.normalized;
                    Script.MoveFromBox();
                    print("hit");
                }
            }
        }
    }

    private void ToMaze()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                if (hitInfo.collider.gameObject.GetComponent<Target3>() != null)
                {
                    Vector3 distanceToTarget = hitInfo.point - transform.position;
                    Vector3 forceDirection = distanceToTarget.normalized;
                    Script.MoveToMaze();

                    print("Maze");
                }
            }
        }
    }
}
