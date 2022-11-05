using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(Animator))]
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerMove : MonoBehaviour
    {
        
        [SerializeField] private float speed;

        private Rigidbody2D _rb;
        private Animator _anim;
        public int InputX, InputY;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
            _anim = GetComponent<Animator>();
        }

        private void FixedUpdate()
        {
            Move();
        }

        private void Update()
        {
            SetDirection();
        }

        private void Move()
        {
            var direction = Vector2.right * Input.GetAxis("Horizontal") + Vector2.up * Input.GetAxis("Vertical");
            _rb.velocity = direction * speed;
        }

        private void SetDirection()
        {
            var tempInputX = Input.GetAxis("Horizontal");
            var tempInputY = Input.GetAxis("Vertical");
            if (tempInputX == 0 && tempInputY == 0) return;
            InputX = tempInputX > 0 ? 1 : tempInputX < 0 ? -1 : 0;
            InputY = tempInputY > 0 ? 1 : tempInputY < 0 ? -1 : 0;
            _anim.SetFloat("HorizontalDirection", InputX);
            _anim.SetFloat("VerticalDirection", InputY);
        }
    }
}