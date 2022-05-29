using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scene_changer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Application.LoadLevel("SampleScene");
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            Application.LoadLevel("SCENE_2_PARTICLE");
        }
    }
}
