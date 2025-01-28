using System;
using System.ComponentModel.DataAnnotations;

namespace CommunityApp_Lab3.Models;

public class Province {
    [Key]
    [Required]
    public string? ProvinceCode { get; set; }

    public string? ProvinceName { get; set; }

    public List<City>? Cities { get; set; }
}
