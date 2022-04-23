using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContrasenia : MonoBehaviour
{
    // Start is called before the first frame update
    string contraseniaCorrecta;
    string contraseniaUsuario;
    public Text ingresoUsuario;
    public GameObject cartelitoMsg;
    public Text textoMsg;

    void Start()
    {
        contraseniaCorrecta = "12345";
        cartelitoMsg.SetActive(false);
    }

    // Update is called once per frame
    
    void Update(){

    }
    public void validarContrasenia()
        {
        contraseniaUsuario = ingresoUsuario.text;
        if (contraseniaUsuario == contraseniaCorrecta)
        {
            cartelitoMsg.SetActive(true);
            textoMsg.text = "Bienvenido";
            Debug.Log("Bienvenido");
        }
        else
        {
            cartelitoMsg.SetActive(true);
            textoMsg.text = "Contraseña Incorrecta";
            Debug.Log("Contraseña Incorrecta");
        }
        }
        
    }

