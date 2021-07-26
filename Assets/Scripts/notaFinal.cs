using System;
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

    private int notaF;
    private int aciertos;
    private int totalPregunta;
    Estrellas estrella;

    // Start is called before the first frame update
    void Start()
    {
        idTema = PlayerPrefs.GetInt("idTema");
        totalPregunta = PlayerPrefs.GetInt("totalPregunta" + idTema.ToString());
        notaF = PlayerPrefs.GetInt("notaFinalTemp" + idTema.ToString());
        aciertos = PlayerPrefs.GetInt("aciertosTemp" + idTema.ToString());
        txtNota.text = notaF.ToString();
        txtInfoLevel.text = "USTED ACERTO " + aciertos.ToString() + " de " + totalPregunta.ToString() + " preguntas";

        estrella = FindObjectOfType<Estrellas>();
        estrella.cambio(idTema);
    }

    public void jugarNuevamente()
    {
        SceneManager.LoadScene("T" + idTema.ToString());
    }
}
