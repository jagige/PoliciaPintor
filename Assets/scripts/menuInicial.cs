using UnityEngine;
using UnityEngine.SceneManagement;

public class menuInicial : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    public void jugarNivelFacil()
    {
        SceneManager.LoadScene("Nivel2");
    }

    public void jugarNivelDificil()
    {
        SceneManager.LoadScene("Nivel1");
    }

    public void salir()
    {
        Application.Quit();
    }

    public void reiniciar()
    {
        SceneManager.LoadScene("menuInicial");
    }
}
