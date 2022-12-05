using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HitMe : MonoBehaviour
{
    public Camera mainCamera;
    public SpriteRenderer circle;
    public TextMeshProUGUI gameheadertext;
    public TextMeshProUGUI countertext;
    int counter = 0;

    private void Start()
    {
        countertext.text = "0";
    }

    public void Hitme()
    {
        counter++;
        print("Hit me.");
        Color randomcolor = Random.ColorHSV();
        circle.color = randomcolor;
        mainCamera.backgroundColor = Random.ColorHSV();
        gameheadertext.color = Random.ColorHSV();
        countertext.text = counter.ToString();
    }




}
