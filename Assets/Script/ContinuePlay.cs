using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinuePlay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int last = PlayerPrefs.GetInt("LastLevel");
        if(last == 0){
            gameObject.SetActive(false);
        }        
    }
    public void Jump(){
        int last = PlayerPrefs.GetInt("LastLevel");        
        SceneManager.LoadScene(last+"");
    }
}
