using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estrellas : MonoBehaviour
{
    public GameObject estrella1;
    public GameObject estrella2;
    public GameObject estrella3;
    private int[] puntajeEstrellas = new int[3] {10,7,5};
    
    public void cambio(int idTema)
    {
        int notaFinal = PlayerPrefs.GetInt("notaFinal" + idTema.ToString());
        //Activar las estrellas segun la nota
        if (notaFinal == puntajeEstrellas[0])
        {
            estrella1.SetActive(true);
            estrella2.SetActive(true);
            estrella3.SetActive(true);
        }
        else if (notaFinal >= puntajeEstrellas[1])
        {
            estrella1.SetActive(true);
            estrella2.SetActive(true);
            estrella3.SetActive(false);
        }
        else if (notaFinal >= puntajeEstrellas[2])
        {
            estrella1.SetActive(true);
            estrella2.SetActive(false);
            estrella3.SetActive(false);
        }
        else
        {
            estrella1.SetActive(false);
            estrella2.SetActive(false);
            estrella3.SetActive(false);
        }
    }
}