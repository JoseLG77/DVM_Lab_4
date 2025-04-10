using System.Xml.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class Mago : Personaje
{
    #region Private

    private int wisdom;
    private int mana;

    #endregion

    #region Getters
    public int Wisdom => wisdom;
    public int Mana => mana;

    #endregion

    #region Constructor
    public Mago(string _name, int _life, float _defense, float _force, int _damage, int _wisdom, int _mana) : base(_name, _life, _defense, _force, _damage)
    {
        wisdom = _wisdom;
        mana = _mana;
    }
    public Mago(Mago copy) : base(copy.Name, copy.Life, copy.Defense, copy.Force, copy.Damage)
    {
        wisdom = copy.Wisdom;
        mana = copy.Mana;
    }
    public void MostrarInfo()
    {
        Debug.Log($"Mago: {Name}, Vida: {Life}, Defensa: {Defense}, Fuerza: {Force}, Daño: {Damage}, Wisdom: {wisdom}, Mana: {mana}");
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
        Mago newMago = new Mago("Mago1", 100, 2.5f, 1.2f, 30, 50, 100);
        Debug.Log("Se ha creado un Mago");
    }

    void OnDestroy()
    {
        Debug.Log("El objeto ha sido destruido");
    }
    #endregion
}
