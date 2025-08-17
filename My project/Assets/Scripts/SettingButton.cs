using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingButton : MonoBehaviour
{
   public void OpenSetting()
    {
        GameObject Menu = GameObject.FindGameObjectWithTag("Menu").transform.gameObject;
        GameObject Gamesettings = GameObject.FindGameObjectWithTag("GamesettingUI").transform.gameObject;
        
        Menu.transform.GetChild(0).gameObject.SetActive(false);
        
        Gamesettings.transform.GetChild(0).gameObject.SetActive(true);

    }

    
}
