using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temaInfo : MonoBehaviour
{
    public int idTema;

    private int notaFinal;

    Estrellas estrella;
    // Start is called before the first frame update
    void Start()
    {
        int notaFinal = PlayerPrefs.GetInt("notaFinal" + idTema.ToString());
        estrella = GetComponent<Estrellas>();
        estrella.cambio(idTema);
    }

    void Update()
    {
        
    }
}