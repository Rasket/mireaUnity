using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCRIPTS_6_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
    }
}
