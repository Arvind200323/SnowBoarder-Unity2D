using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    /// <summary>
    /// Sent when another object enters a trigger collider attached to this
    /// object (2D physics only).
    /// </summary>
    /// <param name="other">The other Collider2D involved in this collision.</param>
    [SerializeField] float timeDelay = 1f;
    [SerializeField] ParticleSystem crashEffect;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Ground"){
            crashEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene" , timeDelay);
            Debug.Log("You Crashed");
        }
    }

    void ReloadScene(){
        SceneManager.LoadScene(0);
    }
}
