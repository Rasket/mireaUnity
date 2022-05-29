using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuscript : MonoBehaviour
{
    public void StartGame()
    {
        Application.LoadLevel("Scene2");
    }

    public void Options(GameObject window)
    {
        window.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
