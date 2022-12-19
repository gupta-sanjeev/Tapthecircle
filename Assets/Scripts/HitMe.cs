using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/// <summary>
/// This script blongs to circle player whose fuctionallity
/// is to chnage corour when user hint on to the circle.
/// 
/// </summary>
public class HitMe : MonoBehaviour
{
    public Camera mainCamera;
    public SpriteRenderer circle;
    public TextMeshProUGUI gameheadertext;
    public TextMeshProUGUI countertext;
    int counter = 0;

    /// <summary>
    /// this fu
    /// </summary>
    private void Start()
	{
        ChangeCircleSize(Screen.orientation);
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
        if (orientation == ScreenOrientation.Portrait || Screen.orientation == ScreenOrientation.PortraitUpsideDown)
        {
           circle.gameObject.transform.localScale = Vector3.one / 2;
        }
        else if (Screen.orientation == ScreenOrientation.LandscapeLeft || Screen.orientation == ScreenOrientation.LandscapeRight)
        {
            circle.gameObject.transform.localScale = Vector3.one*1.2f;
        }
    }
}
