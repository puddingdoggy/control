using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Initialization : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject Menu = GameObject.FindGameObjectWithTag("Menu").transform.gameObject;

        GameObject Gamesettings = GameObject.FindGameObjectWithTag("GamesettingUI").transform.gameObject;

        Menu.transform.GetChild(0).gameObject.SetActive(true);

        Gamesettings.transform.GetChild(0).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
