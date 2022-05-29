using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLookA : MonoBehaviour
{
    public float mouseSens = 10f;

    public Transform Controller;

    float xRotation = 0f;

    public bool CursorLock = true;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (!CursorLock)
        {
            Cursor.lockState = CursorLockMode.Confined;
        } else {
            Cursor.lockState = CursorLockMode.Locked;
        }

        if (Input.GetKeyDown("escape"))
        {
            CursorLock = !CursorLock;
        }

        float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        Controller.Rotate(Vector3.up * mouseX);

    }
}
