using System;
using System.Collections.Generic;

namespace JobBoard.Models
{
  public class JobOpening
  {
    private string _title;
    private string _description;
    private string _name;
    private string _address;
    private string _phone;
    private static List<JobOpening> _openings = new List<JobOpening>{};


    //Getters & Setters call with myJobOpening.title to Get myJobOpening.title = "whatever" to Set
    public string title { get => _title; set => _title = value;}
    public string description { get => _description; set => _description = value;}
    public string name { get => _name; set => _name = value;}
    public string address { get => _address; set => _address = value;}
    public string phone { get => _phone; set => _phone = value;}

    public JobOpening(string title, string description, string name, string address, string phone)
    {
      _title = title;
      _description = description;
      _name = name;
      _address = address;
      _phone = phone;
      _openings.Add(this);
    }

    public static List<JobOpening> GetAll()
    {
      return _openings;
    }
  }
}

// Getters
// public string GetTitle()
// {
//   return _title;
// }
//
// public string GetDescription()
// {
//   return _description;
// }
//
// public string GetName()
// {
//   return _name;
// }
//
// public string GetAddress()
// {
//   return _address;
// }
//
// public string GetPhone()
// {
//   return _phone;
// }
//
//
// public void SetTitle(string newTitle)
// {
//   _title = newTitle;
// }
//
// public void SetDescription(string newDescription)
// {
//   _description = newDescription;
// }
//
// public void SetName(string newName)
// {
//   _name = newName;
// }
//
// public void SetAddress(string newAddress)
// {
//   _address = newAddress;
// }
//
// public void SetPhone(string newPhone)
// {
//   _phone = newPhone;
// }
//
//
// }
// }
//
//
// this is an easy way to do get/set with a bunch of string properties
//
// private string[] contact = new string[5];
//
// public JobOpening(string title, string description, string name, string address, string phone)
// {
//   contact[0] = title;
//   contact[1] = description;
//   contact[2] = name;
//   contact[3] = address;
//   contact[4] = phone;
//   _openings.Add(this);
// }
// public string GetWhatever(int ind)
// {
//   return contact[ind];
// }
