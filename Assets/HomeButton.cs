using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeButton : MonoBehaviour
{
    public void HomeScreen()
    {
        SceneManager.LoadScene("StartScreen");
    }
}
