using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public RectTransform mask;
    public Health health;
    private float originalWidth;
    // Start is called before the first frame update
    void Start()
    {
        originalWidth = mask.sizeDelta.x;
        Debug.Log("Width: " + originalWidth);
        UpdateHealthValue();
        health.onHealthChanged += UpdateHealthValue;
    }
    private void UpdateHealthValue()
    {
        Debug.Log("Ham UpdateHealthValue dang chay");

        float scale = (float)health.healthPoint / health.defaultHealthPoint;
        Debug.Log($"Scale: {scale} | Originalwidth: {originalWidth} | Width moi: {scale * originalWidth }");
        mask.sizeDelta = new Vector2(scale * originalWidth, mask.sizeDelta.y);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
