using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public static EnemyManager Instance { get; private set; }

    public int value;

    public AudioSource backgroundMusic;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            //backgroundMusic.Play();
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
