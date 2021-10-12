using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemyPlay : MonoBehaviour
{
    private AudioSource _audiosource;

    private void Awake() {
        _audiosource = GetComponent<AudioSource>();
    }

    private void OnEnable() {
        PlayerController.enemyDestroyed += PlayAudio;
    }

    private void OnDisable() {
        PlayerController.enemyDestroyed -= PlayAudio;
    }

    private void PlayAudio(){
        _audiosource.Play();
    }
}
