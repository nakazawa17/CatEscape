using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;

public class GameDirector : MonoBehaviour
{
    GameObject hpGauge;
    // Start is called before the first frame update
    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void DecreaseHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
