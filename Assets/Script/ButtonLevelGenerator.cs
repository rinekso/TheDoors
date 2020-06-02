using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonLevelGenerator : MonoBehaviour
{
    public GameObject buttonLevelPrefabs;
    public int maxLevel;
    public Color green;
    // Start is called before the first frame update
    void Start()
    {
        int lastLevel = PlayerPrefs.GetInt("LastLevel");
        for (int i = 0; i < maxLevel; i++)
        {
            GameObject go = Instantiate(buttonLevelPrefabs,transform);
            if(lastLevel > i){
                go.GetComponent<Button>().interactable = true;
            }else{
                go.GetComponent<Button>().interactable = false;
            }
            go.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = (i+1)+"";
            go.GetComponent<JumpScene>().target = (i+1)+"";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
