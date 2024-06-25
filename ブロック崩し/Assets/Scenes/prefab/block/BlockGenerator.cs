using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BlockGen : MonoBehaviour
{
    public GameObject blockPrefab;
    float span = 0.3f;//ブロックの間隔
    int row = 4;//ブロックの列
    int col = 7;//ブロックの行
    int BlockScaleX = 2;//ブロックの幅
    int BlockScaleY = 1;//ブロックの高さ
    int totalBlock ;
    // Start is called before the first frame update
    void Start()
    {
        int px=-7, py=5;//ブロックのX座標とY座標
        totalBlock=row*col;
        ///ブロックの表示
        for(int i=0;i<row; i++) 
        { 
            for(int j=0;j<col; j++)
            {
                GameObject go=Instantiate(blockPrefab);
                go.transform.position = new Vector3(px + (j * (span + BlockScaleX)), py + (i * (BlockScaleY + span)), 0);

            }
        }
    }
    public void BlockDestroyerd()
    {
        totalBlock--;
        if(totalBlock <= 0)
        {
            SceneManager.LoadScene("Result");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
