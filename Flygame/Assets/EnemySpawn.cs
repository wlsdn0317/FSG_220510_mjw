using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;

    float flag = 0;
    GameObject[] enemys = new GameObject[50];

    int enemyIndex = 0;

    private void Start()
    {
        for(int i = 0; i < enemys.Length; i++)
        {
            enemys[i] = Instantiate(enemy, Vector3.zero, Quaternion.identity, this.transform);
            enemys[i].gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        flag += Time.fixedDeltaTime;

        if(flag >= 8f)
        {
            int rd = Random.Range(0, 3);
            float x = Random.Range(-2f, 3);

            if (enemyIndex >= enemys.Length - 1) enemyIndex = 0;

            enemys[enemyIndex].GetComponent<Enemy>().InitEnemy((Enemy.EnemyType)rd, new Vector3(x, 7f, 0));
            flag = 0f;
            enemyIndex++;
        }


    }



}
