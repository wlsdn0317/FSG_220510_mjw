using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logics : MonoBehaviour
{
    public enum PlayerDirection { NONE = 0, LEFT = 1, RIGHT = 2 };
    public PlayerDirection PLAYER_DIR = PlayerDirection.NONE;

    public GameObject bullet;
    public float speed = 10f;
    public float bulletSpeed;   //�Ѿ� ���ǵ�
    public GameObject player;


    public static Logics instance = null;

    private GameObject[] bullets = new GameObject[100]; //�Ѿ��� ������ �迭.
    private int bulletPrimaryNumber = 0;                //�Ѿ��� �ε��� ��.
  

    public static Logics Instance
    {
        get
        {
            return instance;
        }
    }

    private void Awake()
    {
        if (instance == null)instance = this;
    }

    private void Start()
    {
        for(int i = 0; i < bullets.Length; i++)
        {
            bullets[i] = Instantiate(bullet, Vector3.zero, Quaternion.identity, this.transform);
            bullets[i].SetActive(false);
        }
    }

    private void FixedUpdate()
    {
        switch (PLAYER_DIR)
        {
            case PlayerDirection.LEFT: player.transform.position -= new Vector3(speed * Time.fixedDeltaTime, 0, 0); break;
            case PlayerDirection.RIGHT: player.transform.position += new Vector3(speed * Time.fixedDeltaTime, 0, 0); break;
            default: break;
        }
    }

        //�Ѿ��� �����Ǽ� �߻�Ǵ� �Լ�.
    public void Fire()
    {
        if (bulletPrimaryNumber >= bullets.Length) bulletPrimaryNumber = 0;
        bullets[bulletPrimaryNumber].SetActive(true);
        bullets[bulletPrimaryNumber].GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        bullets[bulletPrimaryNumber].transform.position = player.transform.position;
        bullets[bulletPrimaryNumber].GetComponent<Rigidbody2D>().AddForce(new Vector2(0, bulletSpeed * Time.fixedDeltaTime), ForceMode2D.Impulse);
        bulletPrimaryNumber++;
    }
}
