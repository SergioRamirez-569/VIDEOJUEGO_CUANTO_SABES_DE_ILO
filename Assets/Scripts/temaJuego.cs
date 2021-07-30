using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class temaJuego : MonoBehaviour
{
    public Button btnPlay;
    public Text txtNombreTema;
    public GameObject infoLevel;
    public Text txtInfoLevel;
    public string[] nombreTema;

    private int idTema;
    private int totalPregunta;
    Estrellas estrella;
    void Start()
    {
        idTema = 0;
        txtNombreTema.text = nombreTema[idTema];
        txtInfoLevel.text = "";
        infoLevel.SetActive(false);
        btnPlay.interactable = false;
        estrella = GetComponent<Estrellas>();

    }
    public void seleccionTema(int i)
    {
        idTema = i;
        PlayerPrefs.SetInt("idTema", idTema);
        txtNombreTema.text = nombreTema[i];
        totalPregunta = PlayerPrefs.GetInt("totalPregunta" + idTema.ToString());

        int aciertos = PlayerPrefs.GetInt("aciertos" + idTema.ToString());
        
        estrella.cambio(idTema);
        
        txtInfoLevel.text = "USTED ACERTO "+ aciertos.ToString() +" DE "+ totalPregunta.ToString() +" PREGUNTAS!";
        infoLevel.SetActive(true);
        btnPlay.interactable=true;
    }
    public void jugar()
    {
        SceneManager.LoadScene("T"+idTema.ToString());
    }
}
