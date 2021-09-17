using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballon : MonoBehaviour
{
    private int but = 0;
    private void OnTriggerEnter(Collider other) {
        if ( other.gameObject.tag == "lignebut") {
            Debug.Log("BUUUUUUUUUUUUT");
            but++;
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
