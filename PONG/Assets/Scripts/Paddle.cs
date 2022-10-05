using UnityEngine;

public class Paddle : MonoBehaviour
{
    float vertical;
    IInjectable injectable;
    [SerializeField] bool isLeft = false;
    [SerializeField] float speed = 5f;

    private void Start() 
    {
       this.injectable = IDependencyInjector.inject.Invoke();
    }

    void Update()
    {
        if(isLeft)
            vertical = Input.GetAxis("Vertical");
        else 
            vertical = Input.GetAxis("Horizontal");

        injectable.Move(vertical, gameObject.transform, speed);
    }
}
