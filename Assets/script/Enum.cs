using UnityEngine;

public class SequenciaDeGolpes : MonoBehaviour
{
    public Enum<string> ;
    public enum Ataque
{
    SOCO,
    CHUTE,
    VOADORA,
    BANDA,
    CABEÇADA
}

    public void Start()
    {
        nomes = new Enum<string>();
        nomes.Add("SOCO");
        nomes.Add("CHUTE");
        nomes.Add("VOADORA");
        nomes.Add("BANDA");
        nomes.Add("CABECADA");

        foreach (string nome in nomes)
        {
            print(nome);
        }
    }

}
