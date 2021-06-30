using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_Homework_3
{
    public class CarEnthusiast
    {
        public string CarMark { get; set; }
        public int ProductionYear { get; set; }
        public string EngineNumber { get; set; }
        public string BodyNumber { get; set; }
        public string Color { get; set; }
        public string CarLicensePlateNumber { get; set; }
        public string Owner { get; set; }


        public CarEnthusiast(string carMark, int productionYear, string engineNumber, string bodyNumber, string color, string carLicensePlateNumber, string owner)
        {
            CarMark = carMark;
            ProductionYear = productionYear;
            EngineNumber = engineNumber;
            BodyNumber = bodyNumber;
            Color = color;
            CarLicensePlateNumber = carLicensePlateNumber;
            Owner = owner;
        }

        public CarEnthusiast()
        {
            CarMark = String.Empty;
            EngineNumber = String.Empty;
            BodyNumber = String.Empty;
            ProductionYear = 0;
            Color = String.Empty;
            CarLicensePlateNumber = String.Empty;
            Owner = String.Empty;
        }

        public override string ToString()
        {
            return $"{CarMark} {ProductionYear} {EngineNumber} {BodyNumber} {Color} {CarLicensePlateNumber} {Owner}";
        }

    }
}
