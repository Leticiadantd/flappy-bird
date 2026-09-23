using UnityEngine;
using System.Collections.Generic;

public class listTest : MonoBehaviour
{
    public List<string> nomes;

    public void Start()
    {
        nomes = new List<string>();
        nomes.Add("Lucas");
        nomes.Add("João");
        nomes.Add("Maria");
        nomes.Add("José");
        nomes.Add("Ana");

        foreach (string nome in nomes)
        {
            print(nome);
        }
    }

}
