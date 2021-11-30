using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //add sprite render, animator, and rigidbody 2d to player
    

    public Rigidbody2D rb;
    public Vector2 moveBy;
    //reference to animator
    public Animator anim;
    public float moveSpeed; //moderates speed

    public float maxX;
    public float maxY, minY;

    // Update is called once per frame
    void Update()
    {

        
        moveBy.x = Input.GetAxisRaw("Horizontal");
        moveBy.y = Input.GetAxisRaw("Vertical");
        Debug.Log("x = " + moveBy.x + "y = " + moveBy.y);

        anim.SetFloat("Horizontal", moveBy.x);
        anim.SetFloat("Vertical", moveBy.y);
        anim.SetFloat("Speed", moveBy.sqrMagnitude);

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -maxX, maxX);
        transform.position = pos;


                if (transform.position.y >= maxY)
                {
                    transform.position = new Vector3(transform.position.x, maxY, 0);
                }
                else if (transform.position.y <= minY)
                {
                    transform.position = new Vector3(transform.position.x, minY, 0);
                }
      
    }
   

    private void FixedUpdate()
    {
        rb.position += moveBy * moveSpeed* Time.fixedDeltaTime; 
        

    }


    // Use blend tree in unity to attach animation to key presses
    //Two parameter added named Horizontal and Vertical
    // attach walk animations to horizontal and vertical respectively in blend tree
    // change blend mode to "2D Simple Directional"
    //change thresholds to -1 to 1

    //go out of blend tree and return to base layer in animator
    // should have entry move to idle and that move into movement.
    // Movement will return back to idle
    //Use conditions to control when the state will happen

    //drag animator component into anim space in player

    //change value in move speed to 2 to increase speed of actor

    //-160 to -20
}
