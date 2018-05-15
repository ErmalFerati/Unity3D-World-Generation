using System.Collections;
using UnityEngine;

public class WorldBit : MonoBehaviour
{
    public Vector3 size;
    public WorldBit[] matchingWorldBits;

    private IEnumerator Start()
    {
        yield return new WaitForSeconds(1);
        WorldGeneration.instance.generateWorldBit(size);
    }
}