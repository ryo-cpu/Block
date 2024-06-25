using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class block : MonoBehaviour
{
    public int score = 10;
    public BlockGenerator blockGenerator;
    // Start is called before the first frame update
    void Start()
    {
        blockGenerator = FindObjectOfType(BlockGenerator);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void ONCollisionEnter(Collision collision)
    {
        if (ScoreScript.instance != null)
        {
            ScoreScript.instance.ScoreManager(score);
        }
        else
        {
            Debug.LogError("ScoreScriptのインスタンスがありません。");
        }
        blockGenerator.BlockDestroyerd();
        Destroy(gameObject);
    }
}
