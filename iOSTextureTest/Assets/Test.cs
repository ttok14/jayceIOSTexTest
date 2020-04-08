using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Test : MonoBehaviour
{
    private void OnGUI()
    {

        if (GUI.Button(new Rect(0, 0, 200, 200), "NPOT_NoPacking"))
        {
            SceneManager.LoadScene("NPOT_NoPacking");
        }

        if (GUI.Button(new Rect(200, 0, 200, 200), "POT_NoPacking"))
        {
            SceneManager.LoadScene("NPOT_NoPacking");
        }

        if (GUI.Button(new Rect(0, 200, 200, 200), "NPOT_LegacyPacking"))
        {
            SceneManager.LoadScene("NPOT_LegacyPacking");
        }

        if (GUI.Button(new Rect(200, 200, 200, 200), "POT_LegacyPacking"))
        {
            SceneManager.LoadScene("POT_LegacyPacking");
        }

        if (GUI.Button(new Rect(0, 400, 200, 200), "NPOT_SpriteAtlas"))
        {
            SceneManager.LoadScene("NPOT_SpriteAtlas");
        }

        if (GUI.Button(new Rect(200, 400, 200, 200), "POT_SpriteAtlas"))
        {
            SceneManager.LoadScene("POT_SpriteAtlas");
        }
    }
}
