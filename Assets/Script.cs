using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Script : MonoBehaviour
{
    public Complemento complemento;

    public Text textoResultado;

    public void OnStartButtonClick()
    {
        if (complemento != null)
        {
            complemento.StartTracking();

            if (textoResultado != null)
            {
                textoResultado.text = "Iniciando seguimiento...";
            }
        }
    }

    public void OnStopButtonClick()
    {
        if (complemento != null)
        {
            complemento.StopTracking();

            if (textoResultado != null)
            {
                textoResultado.text = complemento.ObtenerDatos();
            }
        }
    }
}
