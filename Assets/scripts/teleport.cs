using UnityEngine;

public class teleport : MonoBehaviour
{
    private Vector3 _Position;
    [SerializeField] private float _posisionX;
    [SerializeField] private float _posisionY;

    private void Start()
    {
        _Position = new Vector3(x: _posisionX, y: _posisionY, z: 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        playerHealt playerHealt = collision.gameObject.GetComponent<playerHealt>();

        if (playerHealt == null)
        {
        }
        else
        {
            playerHealt.transform.position = _Position;
        }
    }
}
