using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //variable for left and right inputs
    public float HorizontalMovementInput;

    //Variable for move speed
    public float MoveSpeed = 10;

    public float JumpForce = 10;

    public Rigidbody PlayerRigidBody;

    public bool IsOnObject;

    //variable for amount of jumps
    private int AmountOfJumps = 2;

    // variable for whether the border is on the left or right
    public bool IsMapEdgeOnLeft;
    //Value of the X coord of the map edge
    public float MapEdge;

    //variable for whether you picked up the soap dish
    public static bool PickedUpSoapDish;
    //variable for whether you picked up the stool
    public static bool PickedUpStool;
    //variable for whether you have placed the stool
    public static bool PlacedStool;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Updates Player Horizontal Movement variable
        HorizontalMovementInput = Input.GetAxis("Horizontal");

        //Moves Player Left and right
        transform.Translate(Vector3.right * HorizontalMovementInput * MoveSpeed * Time.deltaTime);

        //Checks to see what side of the border the player is on
        if (IsMapEdgeOnLeft == false)
        {
            //stopes the player moving to far right
            if (transform.position.x > MapEdge)
            {
                transform.Translate(-Vector3.right * Time.deltaTime * MoveSpeed);
            }
        }else
        {
            //stops the player from moving to far left
            if (transform.position.x < MapEdge)
            {
                transform.Translate(Vector3.right * Time.deltaTime * MoveSpeed);
            }
        }

        //Gets whether space has been press
        if (Input.GetKeyDown("space"))
        {
            //makes sure that there is available jumps
            if (AmountOfJumps > 0)
            {
                //makes the player jump
                PlayerRigidBody.velocity = new Vector3(0, JumpForce, 0);

                //decreases the amount of jumps by 1
                AmountOfJumps--;
            }
        }
    }

    // replenishes jumps when on an object
    private void OnTriggerEnter(Collider other)
    {
        //Makes sure it is only objects the player is standing on that can replenish jumps
        if (other.isTrigger == false)
        {
            AmountOfJumps = 2;
        }
    }
}
