using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisonHandler : MonoBehaviour {

    [Tooltip("In Seconds")] [SerializeField] float levelLoadDelay = 1f;
    [Tooltip("FX Prefab on player")] [SerializeField] GameObject deathFX;


    private void OnTriggerEnter(Collider other)
    {
        StartDeathSequence();
        deathFX.SetActive(true);
        Invoke("ReloadScene", levelLoadDelay);
    }

    private void StartDeathSequence()
    {
        SendMessage("OnPlayerDeath");

    }

    private void ReloadScene()  // Stringed referenced
        {
        SceneManager.LoadScene(1);
        }

}
