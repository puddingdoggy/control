using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour
{     
        public void ExitGame()
        {
            // �༭��ģʽ��ֹͣ����
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            // �����汾���˳�Ӧ��
        Application.Quit();
#endif
        }
    
}
