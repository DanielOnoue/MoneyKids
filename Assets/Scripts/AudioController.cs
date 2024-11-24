using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public static AudioController instance;
    [SerializeField] AudioSource audioManager;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }

        else
        {
            Destroy(gameObject);
        }
    }

    public void ManageVolume()
    {
        if (audioManager.volume <= 0)
        {
            audioManager.volume = 0.5f;
        }

        else
        {
            audioManager.volume = 0;
        }
    }
}
