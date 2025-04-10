using System.Xml.Linq;
using Unity.VisualScripting;
using UnityEditor.PackageManager.UI;
using UnityEngine;

public class Guerrero : Personaje
{
    #region Private

    private int ira;

    #endregion

    #region Getters
    public int Ira => ira;

    #endregion

    #region Constructor
    public Guerrero(string _name, int _life, float _defense, float _force, int _damage, int _ira) : base(_name, _life, _defense, _force, _damage)
    {
        ira = _ira;
    }
    public void MostrarInfo()
    {
        Debug.Log($"Guerrero: {Name}, Vida: {Life}, Defensa: {Defense}, Fuerza: {Force}, Daño: {Damage}, Ira: {ira}");
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
        Guerrero newMago = new Guerrero("Guerrero1", 100, 5f, 2f, 50, 100);
        Debug.Log("Se ha creado un Guerrero");
    }

    void OnDestroy()
    {
        Debug.Log("El objeto ha sido destruido");
    }
    #endregion
}

