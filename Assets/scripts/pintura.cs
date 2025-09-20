using UnityEngine;

public class pintura : MonoBehaviour
{
    public int litros;

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerInventory playerInventory = collision.gameObject.GetComponent<playerInventory>();

        if (playerInventory != null)
        {
            //añade pintura
            playerInventory.addPintura(litros);

            Destroy(gameObject);
        }
    }
}
