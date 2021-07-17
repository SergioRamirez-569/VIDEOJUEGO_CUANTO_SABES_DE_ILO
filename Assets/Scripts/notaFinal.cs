using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class notaFinal : MonoBehaviour
{

    private int idTema;

    public Text txtNota;
    public Text txtInfoLevel;

    public GameObject estrella1;
    public GameObject estrella2;
    public GameObject estrella3;

    private int notaF;
    private int aciertos;
    private int totalPregunta;
    public int[] puntajeEstrellas;

    // Start is called before the first frame update
    void Start()
    {
        idTema = PlayerPrefs.GetInt("idTema");

        estrella1.SetActive(false);
        estrella2.SetActive(false);
        estrella3.SetActive(false);

        totalPregunta = PlayerPrefs.GetInt("totalPregunta" + idTema.ToString());
        notaF = PlayerPrefs.GetInt("notaFinalTemp" + idTema.ToString());
        aciertos = PlayerPrefs.GetInt("aciertosTemp" + idTema.ToString());
        Debug.Log(notaF);
        txtNota.text = notaF.ToString();
        txtInfoLevel.text = "USTED ACERTO " + aciertos.ToString() + " de " + totalPregunta.ToString() + " preguntas";

        if (notaF == puntajeEstrellas[0])
        {
            estrella1.SetActive(true);
            estrella2.SetActive(true);
            estrella3.SetActive(true);
        }
        else if (notaF >= puntajeEstrellas[1])
        {
            estrella1.SetActive(true);
            estrella2.SetActive(true);
            estrella3.SetActive(false);
        }
        else if (notaF >= puntajeEstrellas[2])
        {
            estrella1.SetActive(true);
            estrella2.SetActive(false);
            estrella3.SetActive(false);
        }

    }

    public void jugarNuevamente()
    {
        SceneManager.LoadScene("T" + idTema.ToString());
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
