using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextLevel : MonoBehaviour
{
    string targetScene;
    // Start is called before the first frame update
    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        targetScene = (int.Parse(scene.name)+1)+"";
        if(!Application.CanStreamedLevelBeLoaded(targetScene)){
            GetComponent<Button>().interactable = false;
        }
    }
    public void Jump(){
        SceneManager.LoadScene(targetScene);
    }
}