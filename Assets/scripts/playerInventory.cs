using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerInventory : MonoBehaviour
{
    public int pintura;
    public gameManager vidaGrafitis;
    int numeroDeGrafitis;
    public TextMeshProUGUI pinturaText;
    public TextMeshProUGUI grafitiText;

    private void Start()
    {
        numeroDeGrafitis = vidaGrafitis.cantidadDeGrafitis;
    }

    public void addPintura(int cantidad)
    {
        pintura = pintura + cantidad;
        pinturaText.text = pintura.ToString();
    }

    public void borrarGrafiti(int pinturaNecesaria)
    {
      
            numeroDeGrafitis = numeroDeGrafitis - pinturaNecesaria;
            grafitiText.text = numeroDeGrafitis.ToString();
            pintura = pintura - pinturaNecesaria;
            pinturaText.text = pintura.ToString();
            
    }
    private void Update()
    {
        if (pintura == 0 && numeroDeGrafitis == 0)
        {
            SceneManager.LoadScene("menuVictoria");
        }
    }

}
