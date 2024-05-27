using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterParticle : MonoBehaviour
{

    [SerializeField] int steps;
    [SerializeField]float radius;
    [SerializeField] Color color;

    LineRenderer circleRenderer;


    private void Awake()
    {
        circleRenderer = GetComponent<LineRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DrawCircle(steps,radius,color); 
    }




    void DrawCircle(int steps, float radius, Color particleColor)
    {
        circleRenderer.positionCount = steps;
        circleRenderer.endColor = particleColor;
        circleRenderer.startColor = particleColor;
        for(int currentStep = 0; currentStep < steps; currentStep++) 
        {
            float circumferenceProgress = (float)currentStep / steps;
            float currentRadian = circumferenceProgress * 2 * Mathf.PI;

            float xScaled = Mathf.Cos(currentRadian);
            float yScaled = Mathf.Sin(currentRadian);


            float x = xScaled * radius;
            float y = yScaled * radius;


            Vector3 currentPosition = new Vector3(x, y, 0);


            circleRenderer.SetPosition(currentStep, currentPosition);
        }
    }
}
