<<<<<<< HEAD:Signing/Assets/Scripts/SceneChange.cs
﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEditor.SceneManagement;

public class SceneChange : MonoBehaviour
{
    bool loadingStarted = false;
    float secondsLeft = 0;

    void Start()
    {
        StartCoroutine(DelayLoadLevel(10));
    }

    IEnumerator DelayLoadLevel(float seconds)
    {
        secondsLeft = seconds;
        loadingStarted = true;
        do
        {
            yield return new WaitForSeconds(1);
        } while (--secondsLeft > 0);

        int currentScene = System.Convert.ToUInt16(SceneManager.GetActiveScene().name[0]);
        
        if (currentScene < 90)
        {
            currentScene++;
            SceneManager.LoadScene(System.Convert.ToChar(currentScene).ToString());
            Debug.Log(currentScene);
        }
        else
        {

        }
    }

    void OnGUI()
    {
        if (loadingStarted)
            GUI.Label(new Rect(0, 0, 100, 20), secondsLeft.ToString());
    }
}
=======
﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    bool loadingStarted = false;
    float secondsLeft = 0;

    void Start()
    {
        StartCoroutine(DelayLoadLevel(10));
    }

    IEnumerator DelayLoadLevel(float seconds)
    {
        secondsLeft = seconds;
        loadingStarted = true;
        do
        {
            yield return new WaitForSeconds(1);
        } while (--secondsLeft > 0);

        int currentScene = System.Convert.ToUInt16(SceneManager.GetActiveScene().name[0]);
        
        if (currentScene < 90)
        {
            currentScene++;
            SceneManager.LoadScene(System.Convert.ToChar(currentScene).ToString());
            Debug.Log(currentScene);
        }
        else
        {

        }
    }

    void OnGUI()
    {
        if (loadingStarted)
            GUI.Label(new Rect(0, 0, 100, 20), secondsLeft.ToString());
    }
}
>>>>>>> 0e835b630aac06c38b4582682d964d3fd8e2cc62:Signing/Assets/SceneChange.cs
