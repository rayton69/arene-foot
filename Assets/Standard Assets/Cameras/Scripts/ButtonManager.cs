using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ButtonManager : MonoBehaviour
{
    public Text myText;
    public void QuitButton()
    {
        Debug.Log("vous avez quittez le jeux !!");
        Application.Quit();
    }
    
    public void PlayButton()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void MenuButton()
    {
        SceneManager.LoadScene("MenuInGame");
    }
}
