using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllowController : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player_0");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.1f, 0);

        if (transform.position.y < -5.0f)
        {
            // オブジェクトの破棄(今回は矢にアタッチされているため、これも消える)
            Destroy(gameObject);
        }

        // 矢の位置
        Vector2 p1 = transform.position;
        // 操作キャラクターの位置
        Vector2 p2 = this.player.transform.position;
        // ベクトルの引き算
        Vector2 dir = p1 - p2;
        // キャラクターと矢までの距離
        float d = dir.magnitude;
        // 矢のあたり判定の半径
        float r1 = 0.5f;
        // キャラのあたり判定の半径
        float r2 = 1.0f;

        if (d < r1 + r2)
        {
            //監督スプリクトにキャラと衝突したことを伝える
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHp();

            //director.GetComponent<GameDirector>().Gameover();


            Destroy(gameObject);
        }
    }
}
