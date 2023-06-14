using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    Rigidbody2D rb2d;
    SurfaceEffector2D sf2d;
    [SerializeField] float playerTorque = 1f;
    [SerializeField] float brakeSpeed = 20f;
    [SerializeField] float boostSpeed = 40f;
    [SerializeField] float baseSpeed = 30f;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        sf2d = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerRotate();
        PlayerBoost();
    }

    void PlayerRotate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(playerTorque);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-playerTorque);
        }
    }

    void PlayerBoost(){
        if(Input.GetKey(KeyCode.UpArrow)){
         sf2d.speed = boostSpeed;
        }
        else if(Input.GetKey(KeyCode.DownArrow)){
            sf2d.speed = brakeSpeed;
        }
        else{
            sf2d.speed = baseSpeed;
        }

    }

}
