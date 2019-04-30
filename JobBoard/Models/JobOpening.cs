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

    public JobOpening(string title, string description, string name, string address, string phone)
    {
      _title = title;
      _description = description;
      _name = name;
      _address = address;
      _phone = phone;
      _openings.Add(this);
    }

    //Getters
    public string GetTitle()
    {
      return _title;
    }

    public string GetDescription()
    {
      return _description;
    }

    public string GetName()
    {
      return _name;
    }

    public string GetAddress()
    {
      return _address;
    }

    public string GetPhone()
    {
      return _phone;
    }

    public static List<JobOpening> GetAll()
    {
      return _openings;
    }

    public void SetTitle(string newTitle)
    {
      _title = newTitle;
    }

    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }

    public void SetName(string newName)
    {
      _name = newName;
    }

    public void SetAddress(string newAddress)
    {
      _address = newAddress;
    }

    public void SetPhone(string newPhone)
    {
      _phone = newPhone;
    }


  }
}
