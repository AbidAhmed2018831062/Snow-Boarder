using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustHandler : MonoBehaviour
{
    [SerializeField] ParticleSystem dust;
     void OnCollisionEnter2D(Collision2D other) {
     if(other.gameObject.tag=="Ground"&&FindObjectOfType<Torque>().canMove){
        dust.Play();
     }
    }
     void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.tag=="Ground")
        dust.Stop();
    }
}
