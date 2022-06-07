using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void LateUpdate()
    {
        if (this.transform.position.y >= 15f) this.gameObject.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.collider.gameObject.tag == "Enemy")
        {
            col.collider.GetComponent<Enemy>().DestroyEnemy();
            DestroyBullet();
        }
    }

    public void DestroyBullet()
    {
        this.gameObject.SetActive(false);
    }
}
