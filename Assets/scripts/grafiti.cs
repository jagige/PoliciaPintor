using Unity.VisualScripting;
using UnityEngine;

public class grafiti : MonoBehaviour
{
    public int requisitoGrafiti;

    private void Start()
    {

    }
    
     private void OnTriggerEnter2D(Collider2D collision)
     {
        playerInventory playerInventory = collision.gameObject.GetComponent<playerInventory>();

        if (playerInventory.pintura >= requisitoGrafiti)
        {
                playerInventory.borrarGrafiti(requisitoGrafiti);

                Destroy(gameObject);

        }
     }
    

}
