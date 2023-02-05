using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SwitchScene : MonoBehaviour
{
    
    public GameObject officeBtn;
    public GameObject MotelBtn;
    public GameObject CrimeBtn;

    public GameObject officeCamera;
    public GameObject MotelCamera;
    public GameObject CrimeCamera;

    public GameObject officeDoor;
    public GameObject motelDoor;
    public GameObject crimeDoor;

    public GameObject panel;

    public bool roomOpen;

    public TextMeshProUGUI open;
    

    private void Update()
    {
        officeBtn.SetActive(false);
        MotelBtn.SetActive(false);
        CrimeBtn.SetActive(false);
        office();
        motel();
        crimeScene();
        panelActive();
        checkRooms();
    }

    public void panelActive()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            panel.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            panel.SetActive(false);
        }
    }

    public void office()
    {
        if(officeDoor.activeInHierarchy == false)
        {
            if (officeCamera.activeInHierarchy)
            {
                officeBtn.SetActive(false);
            }
            else
            {
                officeBtn.SetActive(true);
            }
        }
    }

    public void motel()
    {
        if (motelDoor.activeInHierarchy == false)
        {
            if (MotelCamera.activeInHierarchy)
            {
                MotelBtn.SetActive(false);
            }
            else
            {
                MotelBtn.SetActive(true);
            }
        }
    }

    public void crimeScene()
    {
        if (crimeDoor.activeInHierarchy == false)
        {
            if (CrimeCamera.activeInHierarchy)
            {
                CrimeBtn.SetActive(false);
            }
            else
            {
                CrimeBtn.SetActive(true);
            }
        }
    }

    public void ClickOffice()
    {
       

        officeCamera.SetActive(true);
        StartCoroutine(loadscene());
        if (CrimeCamera.activeInHierarchy)
        {
            CrimeCamera.SetActive(false);
        }

        if (MotelCamera.activeInHierarchy)
        {
            MotelCamera.SetActive(false);
        }

    }
    public void ClickMotel()
    {
        MotelCamera.SetActive(true);
        StartCoroutine(loadscene());
        if (CrimeCamera.activeInHierarchy)
        {
            CrimeCamera.SetActive(false);
        }

        if (officeCamera.activeInHierarchy)
        {
            officeCamera.SetActive(false);
        }

    }
    public void ClickCrime()
    {
        CrimeCamera.SetActive(true);
        StartCoroutine(loadscene());
        if (officeCamera.activeInHierarchy)
        {
            officeCamera.SetActive(false);
        }

        if (MotelCamera.activeInHierarchy)
        {
            MotelCamera.SetActive(false);
        }

    }

    IEnumerator loadscene()
    {
        yield return new WaitForSeconds(5f);
        panel.SetActive(false);
    }

    public void checkRooms()
    {
        if (officeDoor.activeInHierarchy == true && motelDoor.activeInHierarchy == true && crimeDoor.activeInHierarchy == true)
        {
            roomOpen = false;
            open.text = "Rooms Available : No rooms are avaliable ";
        }
        else if (officeDoor.activeInHierarchy == false )
        {
            roomOpen = true;
            open.text = "Rooms Available :";
        }
    }
}
