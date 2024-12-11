using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerr : MonoBehaviour
{
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        Debug.Log("Scene pindah");
    }
    public void OnButtonPressed(int buttonId)
    {
        GameManager.Instance.Setdraw(buttonId);

        switch (buttonId)
        {
            case 1:
                SceneManager.LoadScene("Gameplay"); 
                break;
            case 2:
                SceneManager.LoadScene("Gameplay"); 
                break;
            case 3:
                SceneManager.LoadScene("Gameplay");
                break;
            case 4:
                SceneManager.LoadScene("Gameplay");
                break;
            case 5:
                SceneManager.LoadScene("Gameplay");
                break;
            case 6:
                SceneManager.LoadScene("Gameplay");
                break;
            case 7:
                SceneManager.LoadScene("Gameplay");
                break;
            case 8:
                SceneManager.LoadScene("Gameplay");
                break;
            case 9:
                SceneManager.LoadScene("Gameplay");
                break;
            case 10:
                SceneManager.LoadScene("Gameplay");
                break;
            default:
                Debug.LogWarning("Tombol tidak dikenali: " + buttonId);
                break;
        }
    }
}
