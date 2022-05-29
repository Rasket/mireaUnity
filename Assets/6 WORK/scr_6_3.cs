using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_6_3 : MonoBehaviour
{
    private Renderer redenradsf;
    // Start is called before the first frame update
    void Start()
    {
        redenradsf = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        redenradsf.material.color = Color.grey;
    }
}
