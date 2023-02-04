using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class SelectObjext : MonoBehaviour
{
    public Material highlightMaterial;
    public Material selectionMaterial;
   
   

    private Material originalMaterial;
    private Transform highlight;
    private Transform selection;
    private RaycastHit raycastHit;

    


    void Update()
    {
        
        if (highlight != null)
        {
            highlight.GetComponent<MeshRenderer>().material = originalMaterial;
            highlight = null;
        }
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (!EventSystem.current.IsPointerOverGameObject() && Physics.Raycast(ray, out raycastHit)) //Make sure you have EventSystem in the hierarchy before using EventSystem
        {
            highlight = raycastHit.transform;
            if (highlight.CompareTag("Selectable") && highlight != selection)
            {
                if (highlight.GetComponent<MeshRenderer>().material != highlightMaterial)
                {
                    originalMaterial = highlight.GetComponent<MeshRenderer>().material;
                    highlight.GetComponent<MeshRenderer>().material = highlightMaterial;
                }
            }
            else
            {
                highlight = null;
            }
        }


        if (Input.GetKey(KeyCode.Mouse0) && !EventSystem.current.IsPointerOverGameObject()) //Make sure you have EventSystem in the hierarchy before using EventSystem
        {
            if (selection != null)
            {
                selection.GetComponent<MeshRenderer>().material = originalMaterial;
                selection = null;
                
            }
            if (!EventSystem.current.IsPointerOverGameObject() && Physics.Raycast(ray, out raycastHit))
            {
                selection = raycastHit.transform;
                if (selection.CompareTag("Selectable"))
                {
                    selection.GetComponent<MeshRenderer>().material = selectionMaterial;
                    CamerMove.selectionMade = true;

                }
                else
                {
                    selection = null;
                  
                }
                
            }
        }
    }

   
}
