using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class controladorSonidos : MonoBehaviour
{
    public static controladorSonidos instance;

    private AudioSource _AudioSource;

    private void Awake()
    {

        if (instance == null)
        { 
                instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        _AudioSource = GetComponent<AudioSource>();
    }

    public void ejecutarSonido(AudioClip sonido)
    {
        _AudioSource.PlayOneShot(sonido);
    }
}
