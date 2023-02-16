using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] ParticleSystem finishEffect;
   
   private void OnTriggerEnter2D(Collider2D other) {
    if(other.tag=="Player"&&FindObjectOfType<Torque>().canMove){
        finishEffect.Play();
        GetComponent<AudioSource>().Play();
   Invoke("ReloadScene",2f);
   }
   }

   void ReloadScene(){
     SceneManager.LoadScene(0);
   }
   
}
