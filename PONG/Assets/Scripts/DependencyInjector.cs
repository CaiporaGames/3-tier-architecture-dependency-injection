using UnityEngine;

public class DependencyInjector : MonoBehaviour
{
    IInjectable movePadde;

    private void Awake() {
      movePadde = new MovePaddle();
    }
}
