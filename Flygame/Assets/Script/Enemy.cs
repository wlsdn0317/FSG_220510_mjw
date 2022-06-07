using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Sprite[] sprs;

    float speed = 0;
    public enum EnemyType { EnemyTypeA = 0, EnemyTypeB = 1,EnemyTypeC = 2 };
    public EnemyType enemyType = EnemyType.EnemyTypeA;

    //�̵� ������ ������ ������Ʈ
    private void FixedUpdate()
    {
        //�� ��ü�� ������ Y���� -3 ���� ������ �ڵ����� ��Ȱ��ȭ ���ִ� �ڵ�
        if(this.transform.position.y <= -5f)
        {
            this.gameObject.SetActive(false);
        }

        this.transform.position -= new Vector3(0, speed * Time.fixedDeltaTime, 0);
    }

    //�� ��ü �ʱ�ȭ ���ִ� �ڵ�
    public void InitEnemy(EnemyType type , Vector3 pos)
    {
        //��������Ʈ �������ִ� �ڵ�
        this.GetComponent<SpriteRenderer>().sprite = sprs[(int)type];

        switch (type)
        {
            case EnemyType.EnemyTypeA: this.GetComponent<BoxCollider2D>().size = new Vector2(0.45f, 0.45f);
                break;
            case EnemyType.EnemyTypeB: this.GetComponent<BoxCollider2D>().size = new Vector2(0.3f, 0.8f);
                break;
            case EnemyType.EnemyTypeC: this.GetComponent<BoxCollider2D>().size = new Vector2(1f, 1f);
                break;
        }


        this.transform.position = pos;

        speed = (float)Random.Range(1, 5);

        //��Ȱ�� �� �༮�� Ȱ��ȭ ���ִ� ��
        if (!this.gameObject.activeSelf)
        {
            this.gameObject.SetActive(true);
        }
    }

    public void DestroyEnemy() 
    {
        this.gameObject.SetActive(false);
    }
}
