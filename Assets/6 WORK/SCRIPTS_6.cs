using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCRIPTS_6 : MonoBehaviour
{
    public GameObject thisGameObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            thisGameObject.GetComponent<Rigidbody>().AddForce(0, 200, 0);
        }
    }
}
