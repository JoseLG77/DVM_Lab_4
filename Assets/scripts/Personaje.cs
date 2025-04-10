using UnityEditor.PackageManager.UI;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    #region Private

    private string name;
    private int life;
    private float defense;
    private float force;
    private int damage;

    #endregion

    #region Getters

    public string Name => name;
    public int Life => life;
    public float Defense => defense;
    public float Force => force;
    public int Damage => damage;

    #endregion

    #region Constructor
    public Personaje(string Name, int Life, float Defense, float Force, int Damage)
    {
        name = Name;

        life = Life;

        defense = Defense;

        force = Force;

        damage = Damage;

    }
    public void MostrarInfo()
    {
        Debug.Log($"Personaje: {Name}, Vida: {Life}, Defensa: {Defense}, Fuerza: {Force}, Daño: {Damage}");
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
        Personaje newPersonaje = new Personaje("Julius", 100, 3.2f, 1.5f, 10);
        Debug.Log("Se ha creado un personaje");
    }

    void OnDestroy()
    {
        Debug.Log("El objeto ha sido destruido");
    }
    #endregion
}
