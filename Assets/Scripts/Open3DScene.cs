using UnityEngine;
using UnityEngine.SceneManagement;

public class Open3DScene : MonoBehaviour
{
    public void OpenScene ()
    {
        SceneManager.LoadSceneAsync("3DScene", LoadSceneMode.Additive);
    }
}
