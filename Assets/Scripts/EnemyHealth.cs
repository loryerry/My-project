using JetBrains.Annotations;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    private int damage = 10;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PLayerHealth>().ChangeHealth(-damage);
        }
    }
}
