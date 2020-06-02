using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    DoorIndicator[] doors;
    bool isComplete = false;
    public GameObject CompletePanel;
    private void Awake() {
        doors = GameObject.FindObjectsOfType<DoorIndicator>();
    }
    private void Update() {
    }
    public void CheckAllDoors(){
        int c = 0;
        for (int i = 0; i < doors.Length; i++)
        {
            if(doors[i].isClose){
                c++;
            }
        }
        if(c == doors.Length){
            isComplete = true;
        }else{
            isComplete = false;
            c=0;
        }

        if(isComplete){
            CompleteLevel();
            print("complete");
        }
    }
    public void CompleteLevel(){
        Scene scene = SceneManager.GetActiveScene();
        string targetScene = (int.Parse(scene.name)+1)+"";
        int lastLevel = PlayerPrefs.GetInt("LastLevel");
        if(lastLevel < int.Parse(scene.name)){
            if(Application.CanStreamedLevelBeLoaded(targetScene)){
                PlayerPrefs.SetInt("LastLevel",(int.Parse(scene.name)+1));
            }else{
                PlayerPrefs.SetInt("LastLevel",(int.Parse(scene.name)));
            }
        }
        Time.timeScale = 0;
        CompletePanel.SetActive(true);
    }
}
