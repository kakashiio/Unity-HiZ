using UnityEngine;

public class CreateObjects : MonoBehaviour
{
    public int Count = 10000;
    public float Radius = 3;
    public GameObject Prefab;
    
    void Start()
    {
        for (int i = 0; i < Count; i++)
        {
            _CreateGameObject(i);
        }
    }

    private void _CreateGameObject(int i)
    {
        Instantiate(Prefab, Random.insideUnitSphere * Radius, Random.rotation, transform);
    }

}
