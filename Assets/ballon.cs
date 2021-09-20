using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ballon : MonoBehaviour
{
    public affichagescorenew Controller;
    private void OnTriggerEnter(Collider other) {
        if ( other.gameObject.tag == "lignebut") {
            Controller.ButMarquer();
            // SceneManager.LoadScene("SampleScene");
        }
        // if ( other.gameObject.tag == "sortiebut") {
        //     SceneManager.LoadScene("SampleScene");
        //     // SceneManager.LoadScene("SampleScene");
        // }
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
