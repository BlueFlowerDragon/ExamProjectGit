using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearLevel : MonoBehaviour
{
    public GameObject GGUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.layer == 8)
        {
            Debug.Log("GG");
            coll.gameObject.GetComponent<Player>().Controled = false;
            GGUI.SetActive(true);
        }
    }
}
