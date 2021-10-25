using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{
   public void StartGame()
    {
        Cursor.visible = false;
        SceneManager.LoadScene ("test");
    }
    public void BackToTitle()
    {
        Cursor.visible = true;
        SceneManager.LoadScene("Title");
    }
    public void EndGame()
    {
#if UNITY_EDITOR
    UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_WEBPLAYER
    Application.OpenURL("http://sokon.jp/");
#else
        Application.Quit();
#endif
    }
    
}
