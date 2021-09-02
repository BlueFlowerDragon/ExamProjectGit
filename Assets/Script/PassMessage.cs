using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PassMessage : MonoBehaviour
{
    public GameObject self;
    public GameObject Player;
    public void ResetScene()
    {
        SceneManager.LoadScene(0);
    }

    public void KeepPlay()
    {
        Player.GetComponent<Player>().Controled= true;
        self.SetActive(false);
    }
}
