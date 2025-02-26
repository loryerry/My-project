using JetBrains.Annotations;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    private int damage = 10;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<PLayerHealth>().ChangeHealth(-damage);

        //нерабочая строка
        //GetComponent<PLayerHealth>().healthBar.SetMaxHealth(GetComponent<PLayerHealth>().currentHealth);
    }
}
