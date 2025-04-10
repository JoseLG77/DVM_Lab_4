using System.Xml.Linq;
using UnityEngine;

public class Enemigo : Personaje
{
    #region Private

    public GameManager GM;
    static int _score = 0;
    int _level;

    #endregion

    #region Getters
    public int Level => _level;
    public static int Score => _score;

    #endregion

    #region Constructor
    public Enemigo(string name, int life, float defense, float force, int damage, int level)
        : base(name, life, defense, force, damage)
    {
        _level = level;
    }
    public void MostrarInfo()
    {
        Debug.Log($"Enemigo: {Name}, Vida: {Life}, Defensa: {Defense}, Fuerza: {Force}, Daño: {Damage}, Nivel: {_level}");
    }
    #endregion

    #region Destructor
    ~Enemigo()
    {
        _score += 10;
        Debug.Log("Enemigo destruido. Score actual: " + _score);
    }
    #endregion

    #region Void
    void Start()
    {
        Create();
        OnDestroy();
    }
    void Create()
    {
        Enemigo newEnemigo = new Enemigo("Goblin", 50, 1.0f, 0.8f, 5, 1);
        Debug.Log("Se ha creado un Enemigo");
    }

    void OnDestroy()
    {
        Debug.Log("El enemigo ha sido eliminado");
        GameManager.AumentarScore();
    }
    #endregion
}


