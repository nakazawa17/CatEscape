using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;
using TMPro;

public class GameDirector : MonoBehaviour
{
    int hp = 10;
    GameObject game_over;

    public void LostHp(int damage)
    {
        this.hp -= damage;
    }

    public int GetHp()
    {
        return this.hp;
    }

    GameObject hpGauge;
    // Start is called before the first frame update
    void Start()
    {
        this.game_over = GameObject.Find("game_over");
        this.hpGauge = GameObject.Find("hpGauge");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.hp < 1)
        {
            game_over.GetComponent<TextMeshProUGUI>().text = "Game Over";
        }
    }
    public void DecreaseHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
        LostHp(1);

    }
}
