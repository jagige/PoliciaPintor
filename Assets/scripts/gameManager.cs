using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    //public vidas;
    public TextMeshProUGUI pinturaText;
    public TextMeshProUGUI grafitiText;
    public int cantidadDeGrafitis;

    void Start()
    {
        grafitiText.text = cantidadDeGrafitis.ToString();
    }

    
    void Update()
    {
        //cerrar el juego
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        //reiniciar el juego

        if (Input.GetKeyDown(KeyCode.R)) //|| vidas <= 0)
        {
            reiniciar();
        }

        if (Input.GetKeyDown(KeyCode.P)) 
        {
            SceneManager.LoadScene("menuVictoria");
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            SceneManager.LoadScene("menuDerrota");
        }


    }
    public void reiniciar()
    {
        SceneManager.LoadScene("menuInicial");
    }
}
