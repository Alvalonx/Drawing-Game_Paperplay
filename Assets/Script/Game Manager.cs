using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    public int draw;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void Setdraw(int objectDraw)
    {
        draw = objectDraw;
    }
    public int Getdraw()
    {
        return draw;
    }
    public static GameManager Instance
    {
        get
        {
            return instance;
        }
    }
}
