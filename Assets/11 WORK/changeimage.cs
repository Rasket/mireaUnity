using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeimage : MonoBehaviour
{
    public GameObject GameObjectPanel;
    public GameObject GameObjectImage;
    public Sprite Newsprite;

    public void Close()
    {
        GameObjectPanel.SetActive(false);
    }

    // Start is called before the first frame update
    public void ChageImGAE()
    {
        GameObjectImage.GetComponent<Image>().sprite = Newsprite;
    }
}
