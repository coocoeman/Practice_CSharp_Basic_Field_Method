using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Car : MonoBehaviour
{
    [Range(1, 10)] public int 速度 = 1;
    [Range(1, 30)]public int 轉速 = 1;
    float a;
    public void 前()
    {
        transform.Translate(Vector3.forward * 速度 * Time.deltaTime);
        方向();
    }
    public void 後()
    {
        transform.Translate(Vector3.back * 速度 * Time.deltaTime);
        方向();
    }
    private void 方向()
    {
        transform.Rotate(new Vector3(0,a,0) ,轉速 * Time.deltaTime);
    }
    public void 左右(float value)
    {
        a = value;
    }
    public void 左()
    {
        transform.Rotate(Vector3.down, 轉速 * Time.deltaTime);
    }
    public void 右()
    {
        transform.Rotate(Vector3.up, 轉速 * Time.deltaTime);
    }

}
