using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playgame : MonoBehaviour
{
   public Text myText;
    public void ButtonQuit()
    {
        Debug.Log("vous avez quittez le jeux !!");
        Application.Quit();
    }
    
    public void ButtonPlay()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
