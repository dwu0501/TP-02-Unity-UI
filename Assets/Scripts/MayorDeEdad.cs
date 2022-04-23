using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MayorDeEdad : MonoBehaviour
{
    // Start is called before the first frame update
    public int edadUsuario;
    void Start()
    {

        if (edadUsuario >= 18)
        {

            Debug.Log("Es mayor de edad");
        }
        else
        {
            Debug.Log("No es mayor de edad");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
