using UnityEditor;
using UnityEngine;

public class ExitButton : MonoBehaviour
{
    public void OnExitButtonClick()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
