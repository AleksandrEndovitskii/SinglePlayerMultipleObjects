using UnityEngine;
using UnityEngine.InputSystem;

public class PauseToggle : MonoBehaviour
{
    public GameObject panel;
    public void OnPause()
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            panel.SetActive(false);
        }
        else
        {
            Time.timeScale = 0;
            panel.SetActive(true);
        }
    }
}
