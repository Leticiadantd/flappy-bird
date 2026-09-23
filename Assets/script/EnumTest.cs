using UnityEngine;

public enum TipoInimigo
{
    MONSTRO,
    CREEPER,
    SLIME,
    OVNI,
    LOBISOMEM
}

public class EnumTest : MonoBehaviour
{
    public TipoInimigo tipo;
    public TipoInimigo tipo2;

    void Start()
    {
       print(tipo);
    }
}