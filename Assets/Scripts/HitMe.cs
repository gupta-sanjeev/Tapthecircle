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
		CheckInitialOiantation();
		countertext.text = "0";
		OrientationManager.orientationChangedEvent += ChangeCircleSize;
	}
	private void OnDestroy()
	{
		OrientationManager.orientationChangedEvent -= ChangeCircleSize;
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

    void ChangeCircleSize(ScreenOrientation orientation)
    {
        Debug.Log("ChangeCircleSize");
        if (orientation == ScreenOrientation.Portrait)
        {
            circle.gameObject.transform.localScale = Vector3.one / 2;
        }
        else
        {

        }
    }
    void CheckInitialOiantation()
    {
        if (Screen.orientation == ScreenOrientation.Portrait)
        {
            circle.gameObject.transform.localScale = Vector3.one / 2;
        }
        else if (Screen.orientation == ScreenOrientation.LandscapeLeft || Screen.orientation == ScreenOrientation.LandscapeRight)
        {
            circle.gameObject.transform.localScale = Vector3.one;
        }
    }



}
