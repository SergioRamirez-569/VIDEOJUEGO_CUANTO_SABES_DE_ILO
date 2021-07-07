using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Responder : MonoBehaviour
{
    public int idTema;

    public Text pregunta;
    public Text respuestaA;
    public Text respuestaB;
    public Text respuestaC;
    public Text respuestaD;
    public Text infoRespuesta;

    public string[] preguntas;
    public string[] alternativasA;
    public string[] alternativasB;
    public string[] alternativasC;
    public string[] alternativasD;
    public string[] correctas;

    private int idPregunta;

    private float aciertos;
    private float questions;
    private float media;
    // Start is called before the first frame update
    void Start()
    {
        idPregunta = 0;
        questions = preguntas.Length;

        pregunta.text = preguntas[idPregunta];
        respuestaA.text = alternativasA[idPregunta];
        respuestaB.text = alternativasB[idPregunta];
        respuestaC.text = alternativasC[idPregunta];
        respuestaD.text = alternativasD[idPregunta];

        infoRespuesta.text = "RESPONDIENDO " + (idPregunta + 1).ToString() + " DE " + questions.ToString() + " PREGUNTAS";
    }

    public void respuesta(string alternativa)
    {
        if (alternativa == "A")
        {
            if (alternativasA[idPregunta] == correctas[idPregunta])
            {
                aciertos += 1;
            }
        }
        else if (alternativa == "B")
        {
            if (alternativasB[idPregunta] == correctas[idPregunta])
            {
                aciertos += 1;
            }
        }
        else if (alternativa == "C")
        {
            if (alternativasC[idPregunta] == correctas[idPregunta])
            {
                aciertos += 1;
            }
        }
        else if (alternativa == "D")
        {
            if (alternativasD[idPregunta] == correctas[idPregunta])
            {
                aciertos += 1;
            }
        }

        proximaPregunta();
    }

    void proximaPregunta()
    {
        idPregunta += 1;

        if (idPregunta <= (questions - 1))
        {
        pregunta.text = preguntas[idPregunta];
        respuestaA.text = alternativasA[idPregunta];
        respuestaB.text = alternativasB[idPregunta];
        respuestaC.text = alternativasC[idPregunta];
        respuestaD.text = alternativasD[idPregunta];

        infoRespuesta.text = "RESPONDIENDO " + (idPregunta + 1).ToString() + " DE " + questions.ToString() + " PREGUNTAS";
        }
        else
        {
            SceneManager.LoadScene("notaFinal");
        }
    }
}
