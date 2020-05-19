using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {

    public GameObject[] AllEffect;
    int i;
    public Transform mg;
    GameObject MakedObject;
    int counter;

    public bool exp;

    Transform explosion;
    Transform pos1;
    Transform pos2;
    Transform pos3;
    Vector3 explosionpos;
    float timer;

    bool timerstop;
    bool exp1;
    bool exp2;
    bool exp3;
    bool exp4;
    bool exp5;
    bool exp6;

    void Start(){
        counter = 1;

        explosion = GetComponent<Transform>();
        pos1 = GameObject.Find("Sky City/Building type 2").GetComponent<Transform>();
        pos2 = GameObject.Find("Sky City/Top").GetComponent<Transform>();
        pos3 = GameObject.Find("Sky City/Tower1.003").GetComponent<Transform>();

        timerstop = false;
        exp1 = false;
        exp2 = false;
        exp3 = false;
        exp4 = false;
        exp5 = false;
        exp6 = false;

        i = 1;
    }

    void Update(){
        if (timerstop == false){
            timer += Time.deltaTime;
            if (timer >= 18){
                if (exp1 == false){
                Explosions();
                exp1 = true;
                }
            }
            if (timer >= 19){
                if (exp2 == false){
                exp = true;
                Explosions();
                exp2 = true;
                }
            }
            if (timer >= 20){
                if (exp3 == false){
                Explosions();
                exp3 = true;
                timerstop = true;
                }
            }
            if (timer >= 26){
                if (exp4 == false){
                Explosions();
                exp4 = true;
                }
            }
            if (timer >= 27){
                if (exp5 == false){
                exp = true;
                Explosions();
                exp5 = true;
                }
            }
            if (timer >= 28){
                if (exp6 == false){
                Explosions();
                exp6 = true;
                timerstop = true;
                }
            }
        }
    }

    void Explosions(){

            //Debug.Log(counter);

            if (counter == 1) {

                Destroy(MakedObject);
                MakedObject = Instantiate(AllEffect[i - 1], explosion.position, Quaternion.identity) as GameObject;
                explosion.position = pos1.position;
                explosionpos = explosion.position;
                explosionpos.y += 0.5f;
                explosionpos.x += 0.5f;
                explosionpos.z += 2.5f;
                explosion.position = explosionpos;
                i++;
            }

            if (counter == 2) {

                Destroy(MakedObject);
                MakedObject = Instantiate(AllEffect[i - 1], explosion.position, Quaternion.identity) as GameObject;

                explosion.position = pos2.position;
                explosionpos = explosion.position;
                explosionpos.y -= 0.5f;
                explosionpos.x -= 0.5f;
                explosionpos.z -= 2.5f;
                explosion.position = explosionpos;
                i++;
            }

            if (counter == 3) {

                Destroy(MakedObject);
                MakedObject = Instantiate(AllEffect[i - 1], explosion.position, Quaternion.identity) as GameObject;
                explosion.position = pos3.position;
                explosionpos = explosion.position;
                explosionpos.z -= 0.5f;
                explosion.position = explosionpos;
                i++;
            }

            if (counter == 4) {

                Destroy(MakedObject);
                MakedObject = Instantiate(AllEffect[i - 1], explosion.position, Quaternion.identity) as GameObject;
                explosion.position = pos1.position;
                explosionpos = explosion.position;
                explosionpos.y += 0.5f;
                explosionpos.x += 0.5f;
                explosionpos.z += 2.5f;
                explosion.position = explosionpos;
                i++;
            }

            if (counter == 5) {

                Destroy(MakedObject);
                MakedObject = Instantiate(AllEffect[i - 1], explosion.position, Quaternion.identity) as GameObject;
                explosion.position = pos2.position;
                explosionpos = explosion.position;
                explosionpos.y -= 0.5f;
                explosionpos.x -= 0.5f;
                explosionpos.z -= 2.5f;
                explosion.position = explosionpos;
                i++;
            }

            if (counter == 6) {

                Destroy(MakedObject);
                MakedObject = Instantiate(AllEffect[i - 1], explosion.position, Quaternion.identity) as GameObject;
                explosion.position = pos3.position;
                explosionpos = explosion.position;
                explosionpos.z -= 0.5f;
                explosion.position = explosionpos;
                i++;
            }
            counter += 1;          
    }
}
