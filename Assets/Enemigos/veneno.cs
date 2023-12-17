using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class veneno : MonoBehaviour
{
    public GameObject Ex;
    public Text texto;
    public GameObject V;
    public float Venom;
    private int Extra = 0;

    void Update()
    {
        Salud();
        Salud(10f);
    }

    public void Salud(float cantidad)
    {
        if (Ex == null && Extra < 1)
        {
            Venom += cantidad;
            Extra = Extra + 1;
        }
    }
    public void Salud()
    {
        Venom = Venom-Time.deltaTime;
        texto.text = "Muerte por veneno: " + Venom.ToString("f0");
    }
 
    
}
