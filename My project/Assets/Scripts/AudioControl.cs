using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class AudioControl : MonoBehaviour
{
    private AudioSource MenuAudio; //控制的声音是什么
    private Slider AudioSlider;    //获取滑动条



    void Start()
    {
        MenuAudio = GameObject.FindGameObjectWithTag("Menu").transform.GetComponent<AudioSource>();
        AudioSlider = GetComponent<Slider>();

    }
    void Update()
    {
        VolumeControl();
        closeGameSettingUI();
    }
    public void VolumeControl()
    {
        MenuAudio.volume = AudioSlider.value;  //控制声音
    }
    public void closeGameSettingUI()  //关闭游戏设置界面
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            GameObject Menu = GameObject.FindGameObjectWithTag("Menu").transform.gameObject;

            GameObject Gamesettings = GameObject.FindGameObjectWithTag("GamesettingUI").transform.gameObject;
            
            Menu.transform.GetChild(0).gameObject.SetActive(true);
            
            Gamesettings.transform.GetChild(0).gameObject.SetActive(false);
        }
    }
}
