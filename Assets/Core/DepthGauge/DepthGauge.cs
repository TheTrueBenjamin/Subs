using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DepthGauge : MonoBehaviour
{
    public float speed = 0.0f;
    public int topWrapValue = 1953;
    public int bottomWrapValue = -1953;
    public float depth = 0.0f;

    [SerializeField] public RectTransform markers;
    [SerializeField] public TMP_Text depthText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        depth += speed * Time.deltaTime;
        depthText.text = ((int)depth).ToString();

        markers.anchoredPosition = new Vector2(markers.anchoredPosition.x, markers.anchoredPosition.y + speed * Time.deltaTime * 100);
        

        if (markers.anchoredPosition.y > topWrapValue)
        {
            markers.anchoredPosition = new Vector2(markers.anchoredPosition.x, bottomWrapValue);
        }
        else if (markers.anchoredPosition.y < bottomWrapValue)
        {
            markers.anchoredPosition = new Vector2(markers.anchoredPosition.x, topWrapValue);
        }
    }
}
