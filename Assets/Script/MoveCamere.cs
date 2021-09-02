using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamere : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player_Duck");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.gameObject.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, -10f);

    }
}
