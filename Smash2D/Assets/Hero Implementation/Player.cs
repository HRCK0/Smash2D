using Hero_Implementation.Heroes;
using UnityEngine;

namespace Hero_Implementation
{
    public class Player : MonoBehaviour
    {
        //private Shadow player;
        public float movementSpeed;
        public Rigidbody2D theRigidBody;//

        public KeyCode left,
            right,
            jump;

        public Transform groundCheckPoint;
        public bool isGrounded;
        public float groundCheckRadius;
        public LayerMask whatIsGround;

        public Animator anim;

        void Start()
        {
            theRigidBody = GetComponent<Rigidbody2D>();//
            //player = new Shadow(theRigidBody.velocity.x, theRigidBody.velocity.y, 230, 40);
            anim = GetComponent<Animator>();
        }

        void Update()
        {
            isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, whatIsGround);
            if (Input.GetKey(left))
            {
                theRigidBody.velocity = new Vector2(-movementSpeed, theRigidBody.velocity.y);//-player.getMovingSpeed()
            }
            else if (Input.GetKey(right))
            {
                theRigidBody.velocity = new Vector2(movementSpeed, theRigidBody.velocity.y);
            }
            else
            {
                theRigidBody.velocity = new Vector2(0, theRigidBody.velocity.y);
            }
        }

        private void CheckInput()
        {
            if (Input.GetKey(left))
            {
                theRigidBody.velocity = new Vector2(-movementSpeed, theRigidBody.velocity.y);//-player.getMovingSpeed()
            }
            else if (Input.GetKey(right))
            {
                theRigidBody.velocity = new Vector2(movementSpeed, theRigidBody.velocity.y);
            }
            else
            {
                theRigidBody.velocity = new Vector2(0, theRigidBody.velocity.y);
            }
/*
            if (Input.GetKey(jump) && isGrounded)
            {
                theRigidBody.velocity = new Vector2(player.getMovingSpeed(), player.getJumpValue());
            }*/
        }
    }
}