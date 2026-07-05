using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class playerInventory : MonoBehaviour
{
    public int pintura;
    public gameManager vidaGrafitis;
    int numeroDeGrafitis;
    public TextMeshProUGUI pinturaText;
    public TextMeshProUGUI grafitiText;

    [SerializeField] private AudioClip _pintando;
    [SerializeField] private Animator _animator;

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

        _animator.SetBool("pintar", true);
        controladorSonidos.instance.ejecutarSonido(_pintando);
        StartCoroutine(pintar());

    }
    private void Update()
    {
        if (pintura == 0 && numeroDeGrafitis == 0)
        {
            SceneManager.LoadScene("menuVictoria");
        }
    }

    
    private IEnumerator pintar()
    {
        yield return new WaitForSeconds(1);
        _animator.SetBool("pintar", false);
    }

}
