using Hero_Implementation.Heroes;
using UnityEngine;

namespace Hero_Implementation
{
    public class Player : MonoBehaviour
    {
        private Shadow player;
        private Rigidbody2D theRigidBody;

        public KeyCode left,
            right,
            jump;

        public Transform groundCheckPoint;
        public bool isGrounded;
        public float groundCheckRadius;
        public LayerMask whatIsGround;

        private Animator anim;

        void Start()
        {
            theRigidBody = GetComponent<Rigidbody2D>();
            player = new Shadow(theRigidBody.velocity.x);
            anim = GetComponent<Animator>();
            
        }

        void Update()
        {
            isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, whatIsGround);
            
        }

        public void checkInput()
        {
            if (Input.GetKey(left))
            {
                theRigidBody.velocity = new Vector2(-player.getMovingSpeed(), theRigidBody.velocity.y);
            }
        }
    }
}