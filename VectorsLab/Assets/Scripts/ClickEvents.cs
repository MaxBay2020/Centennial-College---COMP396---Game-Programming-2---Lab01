using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickEvents : MonoBehaviour
{
    public Text resultText;
    // v1=(1.5,2.5,3.5)  and v1=(1.0,-3.5,1.5)
    private Vector3 v1 = new Vector3(1.5f, 2.5f, 3.5f);
    private Vector3 v2 = new Vector3(1.0f, -3.5f, 1.5f);
    private float K = 0.75f;
    Vector3 vResult;

    public void V1PlusV2()
    {
        vResult = v1 + v2;
        DisplayResult();
    }

    public void V1MinusV2()
    {
        vResult = v1 - v2;
        DisplayResult();
    }



    public void KMultiplyV1()
    {
        vResult = K * v1;
        DisplayResult();
    }

    public void KMultiplyV2()
    {
        vResult = K * v2;
        DisplayResult();
    }

    public void V1DotV2()
    {
        float result = Vector3.Dot(v1, v2);
        DisplayResult(result);
    }

    public void V1CrossV2()
    {
        vResult = Vector3.Cross(v1, v2);
        DisplayResult();
    }

    public void V1Magnitude()
    {
        float result = Vector3.Magnitude(v1);
        DisplayResult(result);
    }

    public void V2Magnitude()
    {
        float result = Vector3.Magnitude(v2);
        DisplayResult(result);
    }

    public void AngleMethod1()
    {
        float v1Dotv2 = Vector3.Dot(v1, v2);
        float v1Magnitude = Vector3.Magnitude(v1);
        float v2Magnitude = Vector3.Magnitude(v2);
        float angle = Mathf.Acos(v1Dotv2 / (v1Magnitude * v2Magnitude))*Mathf.Rad2Deg;
        DisplayResult(angle);
    }

    public void AngleMethod2()
    {
        float angle = Vector3.Angle(v1,v2);
        DisplayResult(angle);
    }



    public void DisplayResult()
    {
        resultText.GetComponent<Text>().text = vResult.ToString();
    }

    public void DisplayResult(float result)
    {
        resultText.GetComponent<Text>().text = result.ToString();

    }
}
