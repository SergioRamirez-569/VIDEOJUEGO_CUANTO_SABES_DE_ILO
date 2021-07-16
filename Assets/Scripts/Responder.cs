using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Random = System.Random;

public class Responder : MonoBehaviour
{
    private int idTema;
    private int notaFinal;

    public Text pregunta;
    public Text respuestaA;
    public Text respuestaB;
    public Text respuestaC;
    public Text respuestaD;
    public Text infoRespuesta;

    public List<string> preguntas;
    public List<string> alternativasA;
    public List<string> alternativasB;
    public List<string> alternativasC;
    public List<string> alternativasD;
    public List<string> correctas;


    public List<int> nPreguntas;
    public List<List<String>> nRespuestas = new List<List<string>>();
    private int idPregunta;
    private float aciertos;
    private float questions;
    private float media;

    // Start is called before the first frame update
    void Start()
    {
        idTema = PlayerPrefs.GetInt("idTema");
        idPregunta = -1;
        questions = preguntas.Count;
        for (int i = 0; i < questions; i++)
        {
            nPreguntas.Add(i);
        }
        nRespuestas.Add(alternativasA);
        nRespuestas.Add(alternativasB);
        nRespuestas.Add(alternativasC);
        nRespuestas.Add(alternativasD);
        Shuffle(nPreguntas);
        Shuffle(nRespuestas);
        proximaPregunta();
    }
    static void Shuffle<T>(List<T> list)
    {
        Random rng = new Random();
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }

    public void respuesta(string alternativa)
    {
        if (alternativa == "A")
        {
            if (alternativasA[nPreguntas[idPregunta]] == correctas[nPreguntas[idPregunta]])
            {
                aciertos += 1;
            }
        }
        else if (alternativa == "B")
        {
            if (alternativasB[nPreguntas[idPregunta]] == correctas[nPreguntas[idPregunta]])
            {
                aciertos += 1;
            }
        }
        else if (alternativa == "C")
        {
            if (alternativasC[nPreguntas[idPregunta]] == correctas[nPreguntas[idPregunta]])
            {
                aciertos += 1;
            }
        }
        else if (alternativa == "D")
        {
            if (alternativasD[nPreguntas[idPregunta]] == correctas[nPreguntas[idPregunta]])
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
            alternativasA = nRespuestas[0];
            alternativasB = nRespuestas[1];
            alternativasC = nRespuestas[2];
            alternativasD = nRespuestas[3];
            pregunta.text = preguntas[nPreguntas[idPregunta]];
            respuestaA.text = alternativasA[nPreguntas[idPregunta]];
            respuestaB.text = alternativasB[nPreguntas[idPregunta]];
            respuestaC.text = alternativasC[nPreguntas[idPregunta]];
            respuestaD.text = alternativasD[nPreguntas[idPregunta]];

            infoRespuesta.text = "RESPONDIENDO " + (idPregunta + 1).ToString() + " DE " + questions.ToString() + " PREGUNTAS";
        }
        else
        {

            media = 10 * (aciertos / questions);
            notaFinal = Mathf.RoundToInt(media);

            if (notaFinal > PlayerPrefs.GetInt("notaFinal" + idTema.ToString()))
            {
                PlayerPrefs.SetInt("notaFinal" + idTema.ToString(), notaFinal);
                PlayerPrefs.SetInt("aciertos" + idTema.ToString(), (int) aciertos);
            }
            PlayerPrefs.SetInt("notaFinalTemp" + idTema.ToString(), notaFinal);
            PlayerPrefs.SetInt("aciertosTemp" + idTema.ToString(), (int)aciertos);

            SceneManager.LoadScene("notaFinal");
        }
    }
}