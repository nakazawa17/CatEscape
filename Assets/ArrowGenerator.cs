using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    // publicにしたことでインスペクターを通じて直接プレハブの実態を差し込める
    public GameObject arrowPrefab;
    float span = 1.0f;
    float delta = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // １フレームにかかった時間を求め、蓄積する
        // →1秒ごとの実行が可能
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            // Instantiate:引数にプレハブを渡すと戻り値としてプレハブインスタンスを返す
            GameObject go = Instantiate(arrowPrefab);
            // -6から6までの乱数(7は含まない)
            int px = Random.Range(-6, 7);
            go.transform.position = new UnityEngine.Vector3(px, 7, 0);
        }
    }
}
