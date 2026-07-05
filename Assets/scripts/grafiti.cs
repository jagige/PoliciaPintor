using Unity.VisualScripting;
using UnityEngine;
using System.Collections;

public class grafiti : MonoBehaviour
{
    public int requisitoGrafiti;
    [SerializeField] private Animator _animator;
    [SerializeField] private AudioClip _pintando;

    private void Start()
    {

    }
    
     private void OnTriggerEnter2D(Collider2D collision)
     {
        playerInventory playerInventory = collision.gameObject.GetComponent<playerInventory>();

        if (playerInventory.pintura >= requisitoGrafiti)
        {
                playerInventory.borrarGrafiti(requisitoGrafiti);

            _animator.SetBool("pintar", true);
            controladorSonidos.instance.ejecutarSonido(_pintando);
            Destroy(gameObject);
        }
     }

}
