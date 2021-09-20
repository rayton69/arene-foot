using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ButtonManager : MonoBehaviour
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

    public void MenuButton()
    {
        SceneManager.LoadScene("menu");
    }
}
