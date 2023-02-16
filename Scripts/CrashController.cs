using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashController : MonoBehaviour
{
    [SerializeField] ParticleSystem finishEffect;
    [SerializeField] AudioClip crashSfx;
    // Start is called before the first frame update
   private  void OnTriggerEnter2D(Collider2D other) {
    
if(other.tag=="Ground"){
    finishEffect.Play();
    FindObjectOfType<Torque>().disAbleControls();
    GetComponent<AudioSource>().PlayOneShot(crashSfx);
   Invoke("ReloadScene",2f);
   }
   }

   
   void ReloadScene(){
     SceneManager.LoadScene(0);
   }
}
