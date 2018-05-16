using UnityEngine;

public class WorldGeneration : MonoBehaviour
{
    public static WorldGeneration instance;
    public WorldBit currentWorldBit;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        generateWorldBit(Vector3.zero);
    }

    public void generateWorldBit(Vector3 position)
    {
        Instantiate(getMatchingWorldBit(), position, Quaternion.identity);
    }

    private WorldBit getMatchingWorldBit()
    {
        return currentWorldBit = currentWorldBit.matchingWorldBits[Random.Range(0, currentWorldBit.matchingWorldBits.Length)]; 
    }
}