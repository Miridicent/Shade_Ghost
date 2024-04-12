using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas_Switch : MonoBehaviour
{
    public GameObject Canva;
    public GameObject Canva2;

    public void SwitchCanavs()
    {
        Canva.SetActive(false);
        Canva2.SetActive(true);
    }
}
