using System;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;

namespace MvcEL6Validation.Models
{
    public class HomeDataModelEnterpriseLibrary
    {

        [RangeValidator(10, RangeBoundaryType.Inclusive, 110, RangeBoundaryType.Inclusive)]

        public int ValInt1 { get; set; }

        public int? ValInt2 { get; set; }

        [ContainsCharactersValidator("hello", ContainsCharacters.All)]
        [ContainsCharactersValidator("world", ContainsCharacters.All)]
        public string ValString1 { get; set; }

        [StringLengthValidator(5, 20)]
        public string ValString2 { get; set; }

        [NotNullValidator]
        public double ValDouble1 { get; set; }

        public double? ValDouble2 { get; set; }

        [RelativeDateTimeValidator(-120, DateTimeUnit.Year, -18, DateTimeUnit.Year, MessageTemplate = "Must be 18 years or older.")]
        public DateTime ValDateTime1 { get; set; }

        [RelativeDateTimeValidator(-120, DateTimeUnit.Year, -18, DateTimeUnit.Year, MessageTemplate = "Must be 18 years or older.")]
        public DateTime? ValDateTime2 { get; set; }
    }
}