using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Keycode : MonoBehaviour
{
   [SerializeField] private Text Ans;
    private string _Answer = "12345";

    // Update is called once per frame
    public void Number(int number)
    {
        Ans.text += number.ToString();
    }
    public void Execute()
    {
        if(Ans.text == _Answer)
        {
            Ans.text = "CORRECT";
        }
        else
        {
            Ans.text = "INCORRECT";
            
        }
    }
    public void Retry()
    {
        Ans.text = "";   
    }
    
}
