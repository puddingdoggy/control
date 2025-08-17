using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class AudioControl : MonoBehaviour
{
    private AudioSource MenuAudio; //���Ƶ�������ʲô
    private Slider AudioSlider;    //��ȡ������



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
        MenuAudio.volume = AudioSlider.value;  //��������
    }
    public void closeGameSettingUI()  //�ر���Ϸ���ý���
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
