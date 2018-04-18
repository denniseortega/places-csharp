using System.Collections.Generic;
using System;
namespace Places.Models
{
  public class Place
  {
    private string _city;
    private string _description;
    private string _imageURL;
    private int _id;
    private static List<Place> _places = new List<Place> {};

    public Place(string city, string description, string image)
    {
      _city = city;
      _description = description;
      _imageURL = image;
      _id = _places.Count + 1;
    }
    public int GetId()
    {
      return _id;
    }
    public string GetCity()
    {
      return _city;
    }
    public string GetDescription()
    {
      return _description;
    }
    public string GetImageUrl()
    {
      return _imageURL;
    }
    public static List<Place> GetAll()
    {
      return _places;
    }
    public void Save()
    {
      _places.Add(this);
    }
    public static void ClearAll()
    {
      _places.Clear();
    }
    public static Place Find(int searchId)
    {
      return _places[searchId-1];
    }
  }

}
