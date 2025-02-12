using UnityEngine;
using UnityEngine.SceneManagement;

public class MainCtrl : MonoBehaviour
{
    private void Awake()
    {
        Screen.SetResolution(540, 960, false);
        Screen.fullScreen = false;
    }
    public void StartBtnClick()
    {
        SceneManager.LoadScene("Game");
    }
}
