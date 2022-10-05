using UnityEngine;

public class MovePaddle : IInjectable
{
    public MovePaddle(){
        IDependencyInjector.inject += Subscribe;
    }
    public void Move(float direction, Transform transform, float speed)
    {
        transform.Translate(new Vector3(0,direction,0) * Time.deltaTime * speed);
    }

    IInjectable Subscribe(){
        return this;
    }   
}
