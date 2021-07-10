using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class temaJuego : MonoBehaviour
{
    public Button btnPlay;
    public Text txtNombreTema;
    public GameObject infoLevel;
    public Text txtInfoLevel;

    public GameObject estrella1;
    public GameObject estrella2;
    public GameObject estrella3;

    public string[] nombreTema;

    public int numeroQuiz;

    private int idTema;

    void Start()
    {
        idTema = 0;
        txtNombreTema.text = nombreTema[idTema];
        txtInfoLevel.text = "";
        infoLevel.SetActive(false);
        estrella1.SetActive(false);
        estrella2.SetActive(false);
        estrella3.SetActive(false);
        btnPlay.interactable = false;
    }
    public void seleccionTema(int i)
    {
        idTema = i;
        PlayerPrefs.SetInt("idTema", idTema);
        txtNombreTema.text = nombreTema[i];
        int notaFinal = PlayerPrefs.GetInt("notaFinal" + idTema.ToString());
        int aciertos = PlayerPrefs.GetInt("aciertos" + idTema.ToString());

        estrella1.SetActive(false);
        estrella2.SetActive(false);
        estrella3.SetActive(false);

        if (notaFinal == 10)
        {
            estrella1.SetActive(true);
            estrella2.SetActive(true);
            estrella3.SetActive(true);
        }
        else if (notaFinal >= 7)
        {
            estrella1.SetActive(true);
            estrella2.SetActive(true);
            estrella3.SetActive(false);
        }
        else if (notaFinal >= 5)
        {
            estrella1.SetActive(true);
            estrella2.SetActive(false);
            estrella3.SetActive(false);
        }


        txtInfoLevel.text = "USTED ACERTO "+ aciertos.ToString() +" DE "+ numeroQuiz.ToString() +" PREGUNTAS!";
        infoLevel.SetActive(true);
        btnPlay.interactable=true;
    }
    public void jugar()
    {
        SceneManager.LoadScene("T"+idTema.ToString());
    }
    void Update()
    {
        
    }
}
