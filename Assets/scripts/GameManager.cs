using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Private

    static int _score = 0;

    #endregion

    #region Getters
    public static int Score => _score;

    #endregion

    #region Métodos

    public static void AumentarScore()
    {
        _score += 10;
    }

    void Start()
    {
        Personaje personaje = new Personaje("Héroe", 100, 5.0f, 2.0f, 20);
        personaje.MostrarInfo();

        Mago mago1 = new Mago("Merlín", 80, 3.0f, 1.5f, 25, 50, 100);
        mago1.MostrarInfo();

        Mago mago2 = new Mago(mago1);
        mago2.MostrarInfo();

        Enemigo enemigo = new Enemigo("Goblin", 50, 2.0f, 1.2f, 10, 1);
        enemigo.MostrarInfo();
    }
    #endregion
}
