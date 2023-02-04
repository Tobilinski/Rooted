using System.Collections;
using TMPro;
using UnityEngine;

public class CountDown : MonoBehaviour
{
    [SerializeField] float startTime = 60f;
    [SerializeField] TextMeshProUGUI timerText;

    float timer1 = 0f;
    

    void Start()
    {
        StartCoroutine(timerCoroutine());

        StartCoroutine(timerSpeedUP());

    }



    private IEnumerator timerCoroutine()
    {
        timer1 = startTime;
      
        do
        {
           
            timer1 -= Time.deltaTime;
           
            formatText();

            yield return null;

        } while (timer1 > 0);

        Debug.Log("Awe");


    }

    private void formatText()
    {
        
        int day = (int)(timer1 / 86400) % 365;
        int hours = (int)(timer1 / 3600) % 24;
        int minutes = (int)(timer1 / 60) % 60;
        int seconds = (int)(timer1 % 60);

        timerText.text = "";
        if (day > 0)
        {
            timerText.text += day + " d ";
        }

        if (hours > 0)
        {
            timerText.text += hours + " h ";
        }

        if (minutes > 0)
        {
            timerText.text += minutes + " m ";
        }

        if (seconds > 0)
        {
            timerText.text += seconds + " s ";
            
        }
        
    }

    private IEnumerator timerSpeedUP()
    {
        while (timer1 > 0)
        {
            yield return new WaitForSeconds(10f);
            timer1 -= 50f;
            if (timer1 < 10)
            {

                timer1 -= Time.deltaTime;
                formatText();



                yield return null;
            }
           
            
        }
        
       
        


    }


}
