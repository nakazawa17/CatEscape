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

        // 矢の位置(x=0,y=3.2)
        Vector2 p1 = transform.position;
        // 
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.0f;

        if (d < r1 + r2)
        {
            Destroy(gameObject);
        }
    }
}
