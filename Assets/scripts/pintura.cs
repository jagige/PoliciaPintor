using UnityEngine;

public class pintura : MonoBehaviour
{
    public int litros;
    [SerializeField] private AudioClip paintcollect;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerInventory playerInventory = collision.gameObject.GetComponent<playerInventory>();

        if (playerInventory != null)
        {
            //añade pintura
            playerInventory.addPintura(litros);
            controladorSonidos.instance.ejecutarSonido(paintcollect);
            Destroy(gameObject);
        }
    }
}
