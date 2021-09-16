using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ballon : MonoBehaviour
{
    public affichagescorenew Controller;
    private void OnTriggerEnter(Collider other) {
        if ( other.gameObject.tag == "lignebut") {
            Controller.ButMarquer();
        }
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
