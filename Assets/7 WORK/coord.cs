using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coord : MonoBehaviour
{
    public float Speed = 6f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.forward * Time.deltaTime * Speed);
    }
}
