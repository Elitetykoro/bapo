using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoloScreenUI : MonoBehaviour
{
    public void PlayRhythmClick()
    {
        SceneManager.LoadScene("RhythmClick");
    }
}
