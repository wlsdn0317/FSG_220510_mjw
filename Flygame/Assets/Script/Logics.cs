using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logics : MonoBehaviour
{
    public enum PlayerDirection { NONE = 0, LEFT = 1, RIGHT = 2 };
    public PlayerDirection PLAYER_DIR = PlayerDirection.NONE;

    public float speed = 10f;
    public GameObject player;


    public static Logics instance = null;
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

    private void FixedUpdate()
    {
        switch (PLAYER_DIR)
        {
            case PlayerDirection.LEFT: player.transform.position -= new Vector3(speed * Time.fixedDeltaTime, 0, 0); break;
            case PlayerDirection.RIGHT: player.transform.position += new Vector3(speed * Time.fixedDeltaTime, 0, 0); break;
            default: break;
        }
    }
}
