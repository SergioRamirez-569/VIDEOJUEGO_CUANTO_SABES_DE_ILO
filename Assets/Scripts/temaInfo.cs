using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temaInfo : MonoBehaviour
{
    public int idTema;
    public GameObject estrella1;
    public GameObject estrella2;
    public GameObject estrella3;

    private int notaFinal;
    // Start is called before the first frame update
    void Start()
    {
        estrella1.SetActive(false);
        estrella2.SetActive(false);
        estrella3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
