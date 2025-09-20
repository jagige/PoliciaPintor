using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerHealt : MonoBehaviour
{
    public int lives;
    public gameManager reinicio;
    public TextMeshProUGUI vidasText;

    private void Start()
    {
        vidasText.text = lives.ToString();
    }
    private void Update() 
    {
        if (Input.GetKeyDown(KeyCode.L))//hacer daño al jugador presionando L
        {
            DamagePlayer(1);
        }

        if (lives <= 0)
        {
            SceneManager.LoadScene("menuDerrota");
        }

    }
    public void DamagePlayer(int danio)
    {
        lives = lives - danio;

        if (lives >= 0)
        {
            vidasText.text = lives.ToString();
        }
        else
        {
            vidasText.text = "0";
        }
    }
}
