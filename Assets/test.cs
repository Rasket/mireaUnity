using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public GameObject gameObjVar;
    public float floatVar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Randomaizer();
    }

    void Randomaizer()
    {

        floatVar = Random.Range(1, 100);
        // Debug.Log(floatVar);

        if (floatVar == 3)
        {
            // Debug.Log("Проверка условия");
        }
       
    }
}
