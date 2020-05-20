using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchtoFinalScene : MonoBehaviour
{
    float timer;
    public bool timerStart;
    public float GODestroyTime;
    public float SceneSwitchTime;
    void Start()
    {
        if (SceneSwitchTime == 0){
        SceneSwitchTime = 15;
        }
    }

    void Update()
    {
            timer += Time.deltaTime;
            if (timer >= SceneSwitchTime){
                SceneManager.LoadScene("FinalScene", LoadSceneMode.Additive);
                SceneManager.LoadScene("FinalScene");
            }
    }
}
