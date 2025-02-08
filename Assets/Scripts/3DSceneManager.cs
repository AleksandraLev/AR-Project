using UnityEngine;
using UnityEngine.SceneManagement;

public class _3DSceneManager: MonoBehaviour
{
    public void OpenScene ()
    {
        SceneManager.LoadSceneAsync("3DScene", LoadSceneMode.Additive);
    }
    public void CloseScene()
    {
        SceneManager.UnloadSceneAsync("3DScene");
        SceneManager.UnloadSceneAsync("ARScene");
    }
}
