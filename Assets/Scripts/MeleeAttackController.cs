using UnityEngine;

public class MeleeAttackController : MonoBehaviour
{
    public void TryAttack(int dirX, int dirY, float distance, float damage)
    {
        var dir = Vector2.right * dirX + Vector2.up * dirY;
        var raycastTarget = Physics2D.Raycast(transform.position, dir, distance)
            .transform.gameObject;
        if (raycastTarget.TryGetComponent(out IAttackable target))
        {
            target.TryToGainDamage(damage);
        }
    }
}
