using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(Animator))]
    [RequireComponent(typeof(PlayerMove))]
    [RequireComponent(typeof(MeleeAttackController))]
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float attackDistance, damage;
        
        private Animator _anim;
        private PlayerMove _playerMove;
        private MeleeAttackController _attackController;

        private void Awake()
        {
            _anim = GetComponent<Animator>();
            _playerMove = GetComponent<PlayerMove>();
            _attackController = GetComponent<MeleeAttackController>();
        }

        private void Update()
        {
            if (Input.GetButtonDown("Attack"))
            {
                TryAttack();
            }
        }
        
        private void TryAttack()
        {
            _anim.SetTrigger("Attack");
            _attackController.TryAttack(_playerMove.InputX, _playerMove.InputY, attackDistance, damage);
        }
    }
}
