using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torque : MonoBehaviour
{
    [SerializeField] float torqueAmount=1f;
    [SerializeField] float baseSpeed=20f;
    [SerializeField] float boostSpeed=30f;
     SurfaceEffector2D surfaceEffector2D;
    Rigidbody2D rgd;
    public bool canMove=true;
    void Start()
    {
        rgd=GetComponent<Rigidbody2D>();
        surfaceEffector2D=FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove){
       RotatePlayer();
       SpeedPlayer();
        }
    }
    public void disAbleControls()
    {
        canMove=false;
    }
    void SpeedPlayer()
    {
       if(Input.GetKey(KeyCode.UpArrow)) 
       {
       surfaceEffector2D.speed=boostSpeed;
       }
     else if(Input.GetKey(KeyCode.DownArrow)) 
       {
       surfaceEffector2D.speed=baseSpeed;
       }
    }
    void RotatePlayer()
    {
        if(Input.GetKey(KeyCode.LeftArrow)) 
       {
        rgd.AddTorque(torqueAmount);
       }
     else if(Input.GetKey(KeyCode.RightArrow)) 
       {
        rgd.AddTorque(-torqueAmount);
       }
    }
}
