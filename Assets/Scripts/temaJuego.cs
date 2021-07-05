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

    private int idTema;
    // Start is called before the first frame update
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
        txtNombreTema.text = nombreTema[i];
        infoLevel.SetActive(true);
        btnPlay.interactable=true;
    }
    public void jugar()
    {
        SceneManager.LoadScene("T"+idTema);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
