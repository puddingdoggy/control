using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour
{     
        public void ExitGame()
        {
            // 编辑器模式下停止播放
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            // 发布版本中退出应用
        Application.Quit();
#endif
        }
    
}
