using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class src_6_5 : MonoBehaviour
{
    private Vector3 MouseOffset;
    private float NouseZcd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        NouseZcd = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

        MouseOffset = gameObject.transform.position - GetMousePos();
    }

    private Vector3 GetMousePos()
    {
        Vector3 mouserPoINT = Input.mousePosition;

        mouserPoINT.z = NouseZcd;

        return Camera.main.ScreenToWorldPoint(mouserPoINT);
    }

    private void OnMouseDrag()
    {
        transform.position = GetMousePos() + MouseOffset;
    }

}
