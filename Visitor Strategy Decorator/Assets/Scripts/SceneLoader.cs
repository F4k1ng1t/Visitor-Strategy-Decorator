using Pattern.Visitor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject); // Prevent destruction on scene load
    }

    private void OnGUI()
    {
        float buttonWidth = 120f;
        float buttonHeight = 40f;
        float spacing = 10f;
        int buttonCount = 3;

        float totalHeight = (buttonHeight * buttonCount) + (spacing * (buttonCount - 1));
        float x = Screen.width - buttonWidth - 20f; // 20px from right edge
        float y = (Screen.height - totalHeight) / 2f; // Center vertically

        GUI.BeginGroup(new Rect(x, y, buttonWidth, totalHeight + 10f));

        if (GUI.Button(new Rect(0, 0, buttonWidth, buttonHeight), "Scene 0"))
        {
            SceneManager.LoadScene(0);
        }

        if (GUI.Button(new Rect(0, buttonHeight + spacing, buttonWidth, buttonHeight), "Scene 1"))
        {
            SceneManager.LoadScene(1);
        }

        if (GUI.Button(new Rect(0, 2 * (buttonHeight + spacing), buttonWidth, buttonHeight), "Scene 2"))
        {
            SceneManager.LoadScene(2);
        }

        GUI.EndGroup();
    }
}
