using System.Runtime.InteropServices;
using UnityEngine;

public class YandexAdv : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void ShowFullScreenAdv();

    [DllImport("__Internal")]
    private static extern void ShowRevardedAdv(long count);    

    private void Start()
    {
        ShowFullScreenAdv();
    }

    private void OnDestroy()
    {
        ShowFullScreenAdv();
    }

    public void ShowFullScreen()
    {
        ShowFullScreenAdv();
    }    

    public void ShowRevarded(long count)
    {
        ShowRevardedAdv(count);
    }
}