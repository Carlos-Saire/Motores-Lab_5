using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSalir : MonoBehaviour
{
    Button buton;
    private void Awake()
    {
        buton = GetComponent<Button>();
        buton.onClick.AddListener(onClick);
    }
    void onClick()
    {
        Application.Quit();
        Debug.Log("Saliste");
    }
}
