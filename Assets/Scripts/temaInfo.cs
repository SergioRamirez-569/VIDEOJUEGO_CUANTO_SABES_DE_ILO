using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temaInfo : MonoBehaviour
{
    public int idTema;
    Estrellas estrella;
    
    void Start()
    {
        estrella = GetComponent<Estrellas>();
        estrella.cambio(idTema);
    }
}