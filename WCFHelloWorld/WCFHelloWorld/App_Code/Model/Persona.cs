using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descrizione di riepilogo per Persona
/// </summary>
[DataContract]
public class Persona
{
    [DataMember]
    public string Nome { get; set; }
    [DataMember]
    public string Cognome { get; set; }
    [DataMember]
    public DateTime DataNascita { get; set; }

    public Persona(string cognome,string nome,DateTime dataNascita)
    {
        this.Cognome = cognome;
        this.Nome = nome;
        this.DataNascita = dataNascita;
    }
}