using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target2 : MonoBehaviour
{
    private Renderer renderer;
    public Material couch;
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }
    private void OnMouseEnter()
    {
        renderer.material.color = Color.red;
    }
    private void OnMouseExit()
    {
        renderer.material.color = couch.color;
    }
}
