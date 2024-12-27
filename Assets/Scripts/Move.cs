using UnityEngine;

public class Move : MonoBehaviour
{
    float xValue = 0f;
    [SerializeField] float yValue = 0.001f;
    float zValue = 0f;
    private void Start() 
    {
        transform.Translate(xValue, yValue, zValue)k
    }
}
