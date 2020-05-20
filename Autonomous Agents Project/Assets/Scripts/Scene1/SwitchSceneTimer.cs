using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchSceneTimer : MonoBehaviour
{
    float timer;
    public bool timerStart;
    public float GODestroyTime;
    public float SceneSwitchTime;
    void Start()
    {
        timerStart = false;
        if (SceneSwitchTime == 0){
        SceneSwitchTime = 20;
        }
        if (GODestroyTime == 0){
        GODestroyTime = 20;
        }
        timer = 0;
    }

    void Update()
    {
        if (timerStart == true){
            timer += Time.deltaTime;
            if (timer >= GODestroyTime){
                Destroy(gameObject);
            }
            if (timer >= SceneSwitchTime){
                //Debug.Log("Switch");
                SceneManager.LoadScene("SecondScene", LoadSceneMode.Additive);
                SceneManager.LoadScene("SecondScene");
            }
        }
    }
}
