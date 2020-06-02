using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelText : MonoBehaviour
{
    public TMPro.TextMeshProUGUI levelText;
    // Start is called before the first frame update
    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        levelText.text = "Level "+scene.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
