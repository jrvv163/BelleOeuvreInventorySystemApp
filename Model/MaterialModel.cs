using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelleOeuvreComputationSystem.Model;
public class MaterialModel
{
    public string Name { get; set; }
    public string Color { get; set; }
    public string Thickness { get; set; }
    public int Width { get; set; }
    public int Length { get; set; }
    public int TotalSquareInches { get; set; }
    public int PricePerSquareInches { get; set; }
}
