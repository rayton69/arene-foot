using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class affichagescorenew : MonoBehaviour
{
    public Text Score;
    private int but = 0;

    public void ButMarquer()
    {
        but++;
        Score.text = "But : "+but.ToString(); 
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
