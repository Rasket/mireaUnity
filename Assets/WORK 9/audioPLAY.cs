using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioPLAY : MonoBehaviour
{
    public AudioSource soundEFF;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        soundEFF.Play();
    }
}
