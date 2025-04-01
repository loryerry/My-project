using JetBrains.Annotations;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public int damage = 10;
    public Transform attackPoint;
    public float weaponRange;
    public LayerMask playerLayer;
    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PLayerHealth>().ChangeHealth(-damage);
        }
    }
    */

    public void Attack()
    {
        Collider2D[] hits = Physics2D.OverlapCircleAll(attackPoint.position, weaponRange, playerLayer);

        if(hits.Length > 0)
        {
            hits[0].GetComponent<PLayerHealth>().ChangeHealth(-damage);  
        }
    }
}
