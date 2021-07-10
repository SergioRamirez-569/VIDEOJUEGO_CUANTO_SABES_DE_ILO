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

    // Start is called before the first frame update
    void Start()
    {
        idTema = PlayerPrefs.GetInt("idTema");

        estrella1.SetActive(false);
        estrella2.SetActive(false);
        estrella3.SetActive(false);

        
        notaF = PlayerPrefs.GetInt("notaFinalTemp" + idTema.ToString());
        aciertos = PlayerPrefs.GetInt("aciertosTemp" + idTema.ToString());

        txtNota.text = notaF.ToString();
        txtInfoLevel.text = "USTED ACERTO " + aciertos.ToString() + " de 20 preguntas";

        if (notaF == 10)
        {
            estrella1.SetActive(true);
            estrella2.SetActive(true);
            estrella3.SetActive(true);
        }
        else if (notaF >= 7)
        {
            estrella1.SetActive(true);
            estrella2.SetActive(true);
            estrella3.SetActive(false);
        }
        else if (notaF >= 5)
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
