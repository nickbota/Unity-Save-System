using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public void LoadLevelNumber(int _index)
    {
        SceneManager.LoadScene(_index);
    }
}