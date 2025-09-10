using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public void OnHomeScene()
    {
        SceneManager.LoadScene(0);
    }
    
    public void OnGameScene()
    {
        SceneManager.LoadScene(1);
    }
    
    public void OnLosseScene()
    {
        SceneManager.LoadScene(2);
    }
}
