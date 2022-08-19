using System.ComponentModel.DataAnnotations;
using System;

namespace AnimalShelter.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    public string AnimalName { get; set; }
    [Required]
    public string AnimalSpecies { get; set; }
    [Required]
    public string AnimalBreed { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    public int UserId { get; set; }
    [Required]
    public bool Availability { get; set; } = true;
    [Required]
    public DateTime DateCreated { get; set; }
    [Required]
    public DateTime DateModified { get; set; }
  }
}