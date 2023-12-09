using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenceChanger : MonoBehaviour
{
    public float waitTime;
    public int scenceId;
    private bool isSceneChanged;

    private void Update()
    {
        waitTime -= Time.deltaTime;
        if(waitTime <= 0 && !isSceneChanged)
        {
            isSceneChanged = true;
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }

}
