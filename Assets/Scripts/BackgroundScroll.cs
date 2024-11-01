using UnityEngine;
using UnityEngine.UI;

public class BackgroundScroll : MonoBehaviour
{
    [SerializeField] private RawImage _image;
    [SerializeField] private float _x, _y;

    // Update is called once per frame
    void Update()
    {
        Scroll();
    }

    private void Scroll(){
        _image.uvRect = new Rect(_image.uvRect.position + new Vector2(_x,_y) * Time.deltaTime, _image.uvRect.size);
    }
}