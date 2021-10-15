using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{
   public void StartGame()
    {
        SceneManager.LoadScene ("test");
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
